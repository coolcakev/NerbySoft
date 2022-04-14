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
                        {DateHelper.DateFormat( props.dateAdded)}
                    </div>
                </div>

                <div className="announcement_btn">
                    <MyButton  onClick={()=>props.updateModalOpen(props.id)}>Update</MyButton>
                    <MyButton  onClick={()=>props.viewModalOpen({title:props.title,description:props.description,dateAdded:props.dateAdded})}>View</MyButton>
                    <MyButton  onClick={props.deleteAnnouncement}>delete</MyButton>
                </div>

            </div>
        </div>
    )
}
