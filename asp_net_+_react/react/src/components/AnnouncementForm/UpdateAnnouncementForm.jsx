import React, { useEffect } from 'react'
import AnnouncementService from '../../api/AnnouncementsService';
import AnnouncementForm from './AnnouncementForm';

export default function UpdateAnnouncementForm(props) {

    async function updateAnnouncement(updatedAnnouncement) {

        props.setVisible(false);
        await AnnouncementService.UpdateAnnouncement(updatedAnnouncement)
        props.setAnnouncements(props.announcements.map(announcement => announcement.id !== props.announcementId ? announcement : updatedAnnouncement));
    }
    let announcement = props.announcements.find(announcement => announcement.id === props.announcementId);
    let textButton="Create announcement"
    return (
        <>
            <AnnouncementForm AnnouncementMethod={updateAnnouncement} announcement={announcement} textButton={textButton}/>
        </>
    )
}
