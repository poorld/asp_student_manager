saveToLocal = (obj, name) => {
    let json = JSON.stringify(obj)
    localStorage.setItem(name, json)
}

getObjByLocal = (name) => {
    return JSON.parse(localStorage.getItem(name))
}

removeByLocal = (name) => {
    localStorage.removeItem(name)
}
　　