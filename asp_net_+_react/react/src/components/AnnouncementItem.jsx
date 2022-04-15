import React from 'react'
import DateHelper from '../helpers/dateHelpers'
import MyButton from './UI/Button/MyButton'

export default function AnnouncementItem(props) {

     let styleForButton={
         
     }
    return (
        <div>
            <div className="announcement">
                <div className="announcement_content">
                    <strong>{props.number}. {props.title}</strong>
                    <div>
                       {props.description}
                    </div>
                    <div>
                        { props.creationDate}
                    </div>
                </div>

                <div className="announcement_btn">
                    <MyButton  onClick={()=>props.updateModalOpen(props.id)}>Update</MyButton>
                    <MyButton  onClick={()=>props.viewModalOpen({title:props.title,description:props.description,creationDate:props.creationDate})}>View</MyButton>
                    <MyButton  onClick={props.deleteAnnouncement}>delete</MyButton>
                </div>

            </div>
        </div>
    )
}
