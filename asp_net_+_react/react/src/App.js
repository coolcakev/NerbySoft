
import React, { useEffect } from 'react';
import AnnouncementService from './api/AnnouncementsService';
import CreateAnnouncementForm from './components/AnnouncementForm/CreateAnnouncementForm';
import UpdateAnnouncementForm from './components/AnnouncementForm/UpdateAnnouncementForm.jsx';
import AnnouncementList from './components/AnnouncementList';
import MyButton from './components/UI/Button/MyButton';
import MyModal from './components/UI/Modal/MyModal';
import ViewAnnouncement from './components/ViewAnnouncement';
import './styles/App.css';

function App() {
  let [announcements, setAnnouncements] = React.useState([]);
  let [visible, setVisible] = React.useState(false)
  let [modalComponent, setModalComponent] = React.useState()
  console.log("App render");


  function deleteAnnouncement(announcementId) {
    AnnouncementService.DeleteAnnouncement(announcementId);
    setAnnouncements(prevAnnouncements =>
      prevAnnouncements.filter(prevAnnouncement => prevAnnouncement.id !== announcementId)
    );
  }
  function createModalOpen() {
    setModalComponent(<CreateAnnouncementForm
      setVisible={setVisible}
      setAnnouncements={setAnnouncements}
    />)
    setVisible(true);
  }
  function updateModalOpen(announcementId) {
    setModalComponent(<UpdateAnnouncementForm
      setVisible={setVisible}
      announcementId={announcementId}
      announcements={announcements}
      setAnnouncements={setAnnouncements}
    />)
    setVisible(true);
  }
  function viewModalOpen(announcement) {
    setVisible(true);
    setModalComponent(<ViewAnnouncement   
      {...announcement}
    />)
  }
  console.log("modalComponent :")
  console.log(modalComponent)
  return (
    <div className="App" >
      <MyButton onClick={createModalOpen}>
        Create Announcement
      </MyButton>
      <MyModal
        visible={visible}
        setVisible={setVisible}
      >
        {modalComponent}
      </MyModal>

      <AnnouncementList setAnnouncements={setAnnouncements} updateModalOpen={updateModalOpen} deleteAnnouncement={deleteAnnouncement} viewModalOpen={viewModalOpen} announcements={announcements} title={"my list"} />

    </div>
  );
}

export default App;
