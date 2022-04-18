import React, { useEffect } from 'react'
import MyButton from '../UI/Button/MyButton'
import MyInput from '../UI/Input/MyInput'
import ValidComponent from './ValidComponent'

export default function AnnouncementForm(props) {
    console.log("props.announcement")
    console.log(props.announcement)
    let [announcement, setAnnouncement] = React.useState({
        title: "",
        description: "",
    })
    let [isValidForm, setIsValidForm] = React.useState(true)
    let [error, setError] = React.useState({
        title: [],
        description: [],
        price: []

    })

    function validateTitle(value) {
        let titleError=[]
        if (value == "") {
            titleError.push("Title is empty")
        }
        if (titleError.length != 0 || !isValidForm) {
            setIsValidForm(false);
        } 
        setIsValidForm(true);
        setError({ ...error, title: titleError })     
        return   titleError 
       
    }
    function validateDescription (value) { 
        let deskError = [];
        if (value == "") {
            deskError.push("Description is empty")
        }
        if (deskError.length != 0 || !isValidForm) {
            setIsValidForm(false);
        }
         setIsValidForm(true);
        setError({ ...error, description: deskError })
        return   deskError 
     }
    console.log("render CreateAnnouncementForm")
    console.log("announcement")
    console.log(announcement)
    
    useEffect(() => {
        let announcement =InitializeAnnouncement();
        let titleInvalidMessage=  validateTitle(announcement.title);
        let descriptionInvalidMessage=  validateDescription(announcement.description);
      
          setError({title: titleInvalidMessage,description:descriptionInvalidMessage })     
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
        validateTitle(title1)
        setAnnouncement(prevAnnouncement => { return { ...prevAnnouncement, title: title1 } });

    }
    function changeDescription(event) {
        let desk = event.target.value;
        validateDescription(desk)
        setAnnouncement(prevAnnouncement => { return { ...prevAnnouncement, description: desk } });

    }
    function submitAnnouncement(event) {
        event.preventDefault();
        if (!isValidForm) {
            return;
        }
        props.AnnouncementMethod(announcement);
        setAnnouncement(
             { description: "", title: "" }
        );
    }

    return (
        <div style={{ width: "100%" }}>
             <ValidComponent error={error.title}>
                <MyInput classNameElement="" onChange={changeTitle} value={announcement.title} type="text" placeholder="title" />
            </ValidComponent>
            <ValidComponent error={error.description}>
                <MyInput classNameElement="" onChange={changeDescription} value={announcement.description} type="text" placeholder="description" />
            </ValidComponent>         
            <MyButton onClick={submitAnnouncement}>{props.textButton}</MyButton>
        </div>
    )
}
