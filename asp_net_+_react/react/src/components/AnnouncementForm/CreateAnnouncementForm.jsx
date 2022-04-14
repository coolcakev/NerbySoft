import React from 'react'
import AnnouncementService from '../../api/AnnouncementsService';
import AnnouncementForm from './AnnouncementForm';

export default function CreateAnnouncementForm(props) {

    async function createAnnouncement(announcement) {
        props.setVisible(false);
      let createdAnnouncement=  await AnnouncementService.CreateAnnouncement(announcement);
        props.setAnnouncements(prevAnnouncements=>[...prevAnnouncements,createdAnnouncement]);
    }
    let textButton = "Create announcement"
    let styleTitleCreateAnnouncementForm = {
        marginBottom: "10px",
    }
    return (
        <>
            <h1 style={styleTitleCreateAnnouncementForm}>Create announcement</h1>
            <AnnouncementForm AnnouncementMethod={createAnnouncement} textButton={textButton} />
        </>
    )
}
