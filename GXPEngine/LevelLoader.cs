using GXPEngine;
using System.Collections.Generic;
using TiledMapParser;


    public class level : GameObject
    {
    TiledLoader loader;

    public level(string filename)
    {
        loader = new TiledLoader(filename);
        CreateLevel();
    }
    void CreateLevel(bool includeimagelayers = true)
    {
        //loader.addColliders;
        loader.rootObject = this;
        loader.LoadTileLayers();
        loader.autoInstance= true;
        loader.LoadObjectGroups();

    }
    }

