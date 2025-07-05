/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Ie.V20200304.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FrameTagRec : AbstractModel
    {
        
        /// <summary>
        /// 标签类型：
        /// "Common": 通用类型
        /// "Game":游戏类型
        /// </summary>
        [JsonProperty("TagType")]
        public string TagType{ get; set; }

        /// <summary>
        /// 游戏具体类型:
        /// "HonorOfKings_AnchorViews":王者荣耀主播视角
        /// "HonorOfKings_GameViews":王者荣耀比赛视角
        /// "LOL_AnchorViews":英雄联盟主播视角
        /// "LOL_GameViews":英雄联盟比赛视角
        /// "PUBG_AnchorViews":和平精英主播视角
        /// "PUBG_GameViews":和平精英比赛视角
        /// </summary>
        [JsonProperty("GameExtendType")]
        public string GameExtendType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TagType", this.TagType);
            this.SetParamSimple(map, prefix + "GameExtendType", this.GameExtendType);
        }
    }
}

