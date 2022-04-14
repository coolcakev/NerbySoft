import { useMemo } from "react";

export const useSortAnnouncement = (announcements, sort) => {
    let sortedAnnouncements = useMemo(() => {
        console.log("Sort announcements")
        if (sort) {
            return [...announcements].sort((a, b) => a[sort].localeCompare(b[sort]))
        }
        return announcements;
    }, [sort, announcements])
    return sortedAnnouncements
}

// export const useAnnouncements = (announcements, sort, query) => {
    
//     let searchAndSortAnnouncements = useMemo(() => {
//         return getAnnouncements(sort,query)
//     }, [query,sort, announcements])
//     console.log(searchAndSortAnnouncements);
//     return searchAndSortAnnouncements;
// }
export const useAnnouncements = (announcements, sort,query) =>{
    const sortedAnnouncements = useSortAnnouncement(announcements, sort) 

     const sortedAndSearcedAnnouncements = useMemo(() => {
        return sortedAnnouncements.filter(announcement => announcement.title.toLocaleLowerCase().includes(query))
    }, [query, sortedAnnouncements])
    return sortedAndSearcedAnnouncements;
} 