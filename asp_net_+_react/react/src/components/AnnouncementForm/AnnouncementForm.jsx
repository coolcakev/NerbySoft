import React, { useEffect } from 'react'
import MyButton from '../UI/Button/MyButton'
import MyInput from '../UI/Input/MyInput'

export default function AnnouncementForm(props) {
    console.log("props.announcement")
    console.log(props.announcement)
    let [announcement, setAnnouncement] = React.useState({
        title: "",
        description: "",
    })
    console.log("render CreateAnnouncementForm")
    console.log("announcement")
    console.log(announcement)
    
    useEffect(() => {
        let announcement =InitializeAnnouncement();
        setAnnouncement(announcement);
    }, [props.announcement]);
    function InitializeAnnouncement() {
        if (props.announcement === undefined) {
            return {
                title: "",
                description: "",
            }
        }
        return props.announcement; 
    }
    function changeTitle(event) {
        let title1 = event.target.value;
        setAnnouncement(prevAnnouncement => { return { ...prevAnnouncement, title: title1 } });

    }
    function changeDescription(event) {
        let desk = event.target.value;
        setAnnouncement(prevAnnouncement => { return { ...prevAnnouncement, description: desk } });

    }
    function submitAnnouncement(event) {
        event.preventDefault();
        props.AnnouncementMethod(announcement);
        setAnnouncement(
             { description: "", title: "" }
        );
    }

    return (
        <div style={{ width: "100%" }}>
            <MyInput onChange={changeTitle} value={announcement.title} type="text" placeholder="title" />
            <MyInput onChange={changeDescription} value={announcement.description} type="text" placeholder="description" />
            <MyButton onClick={submitAnnouncement}>create</MyButton>
        </div>
    )
}
