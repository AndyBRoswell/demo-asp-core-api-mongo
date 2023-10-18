use work
db.dropDatabase()
db.createCollection("video")
db.video.insertMany([
    {
        title: 'Seismo',
        duration: '3:20:29',
        aspect_ratio: ['1.90:1'],
        frame_rate: '120',
        sound_mix: ['Dolby Atmos', 'Auro 3D', 'DTS:X', 'IMAX 12-Track', 'IMAX 6-Track',],
        camera: ['RED V-RAPTOR XL 8K VV', 'Panavision Millennium DXL2', 'Blackmagic URSA Mini Pro 12K',],
        cinematographic_process: ['Digital Intermediate (8K) (master format)', 'Dolby Vision',],
        printed_film_format: ['DCP Digital Cinema Package',]
    },
    {
        title: 'Giant Boom',
        duration: '4:16:20',
        aspect_ratio: ['1.90:1'],
        frame_rate: '120',
        sound_mix: ['Dolby Atmos', 'Auro 3D', 'DTS:X', 'IMAX 12-Track', 'IMAX 6-Track',],
        camera: ['RED V-RAPTOR XL 8K VV', 'Panavision Millennium DXL2', 'Blackmagic URSA Mini Pro 12K',],
        cinematographic_process: ['Digital Intermediate (8K) (master format)', 'Dolby Vision',],
        printed_film_format: ['DCP Digital Cinema Package',]
    },
])
