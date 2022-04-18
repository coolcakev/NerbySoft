import React, { useEffect } from 'react'
import AnnouncementService from '../../api/AnnouncementsService';
import AnnouncementForm from './AnnouncementForm';

export default function UpdateAnnouncementForm(props) {

    async function updateAnnouncement(updatedAnnouncement) {

        props.setVisible(false);
        await AnnouncementService.UpdateAnnouncement(updatedAnnouncement)
       props.setTakeListOfAnnouncement(prevTakeListOfAnnouncement=>prevTakeListOfAnnouncement+1)
    }
    let announcement = props.announcements.find(announcement => announcement.id === props.announcementId);
    let textButton="Update"
    let styleTitleCreateAnnouncementForm = {
        marginBottom: "10px",
    }
    return (
        <>
            <h1 style={styleTitleCreateAnnouncementForm}>Update announcement</h1>

            <AnnouncementForm AnnouncementMethod={updateAnnouncement} announcement={announcement} textButton={textButton}/>
        </>
    )
}
