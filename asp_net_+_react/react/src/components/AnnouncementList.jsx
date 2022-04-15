import React, { useEffect } from 'react'
import { TransitionGroup, CSSTransition } from 'react-transition-group'
import Loader from './UI/Loader/Loader'
import AnnouncementItem from './AnnouncementItem'
import { useFetching } from '../hooks/useFetching';
import AnnouncementService from '../api/AnnouncementsService';

export default function AnnouncementList(props) {
    console.log("isTakeListOfAnnouncement AnnouncementList Component : "+props.isTakeListOfAnnouncement)
  
    let [fetchAnnouncements,isAnnouncementsLoading,error]=useFetching(async()=>{       
        let announcements = await AnnouncementService.GetAnnoncments();       
        props.setAnnouncements(announcements)
      });
      useEffect(() => {
        fetchAnnouncements();
    
      }, [props.isTakeListOfAnnouncement]);
      console.log("isTakeListOfAnnouncement AnnouncementList Component : "+props.isTakeListOfAnnouncement)
 
    if (isAnnouncementsLoading) {
        return <Loader />
    }
    console.log("AnnouncementList " + props.announcements.length)
    console.log(props.announcements)
    if (props.announcements.length === 0) {
        return (
            <div>
                <h2 style={{ textAlign: 'center' }}>Announcement not found</h2>
            </div>
        )
    }

    return (
        <div>          
            <TransitionGroup className="todo-list">
                {props.announcements.map((announcement, index) => {
                    return (
                        <CSSTransition
                            key={announcement.id}
                            timeout={500}
                            classNames="announcement"
                        >
                            <AnnouncementItem {...announcement} number={index + 1} updateModalOpen={props.updateModalOpen} deleteAnnouncement={() => props.deleteAnnouncement(announcement.id)} viewModalOpen={props.viewModalOpen} />
                        </CSSTransition>
                    )
                })}
            </TransitionGroup>     

        </div>
    )
}
