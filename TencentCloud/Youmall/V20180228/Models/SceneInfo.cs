/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Youmall.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SceneInfo : AbstractModel
    {
        
        /// <summary>
        /// 场景图
        /// </summary>
        [JsonProperty("ScenePictureURL")]
        public string ScenePictureURL{ get; set; }

        /// <summary>
        /// 抓拍头像左上角X坐标在场景图中的像素点位置
        /// </summary>
        [JsonProperty("HeadX")]
        public long? HeadX{ get; set; }

        /// <summary>
        /// 抓拍头像左上角Y坐标在场景图中的像素点位置
        /// </summary>
        [JsonProperty("HeadY")]
        public long? HeadY{ get; set; }

        /// <summary>
        /// 抓拍头像在场景图中占有的像素宽度
        /// </summary>
        [JsonProperty("HeadWidth")]
        public long? HeadWidth{ get; set; }

        /// <summary>
        /// 抓拍头像在场景图中占有的像素高度
        /// </summary>
        [JsonProperty("HeadHeight")]
        public long? HeadHeight{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ScenePictureURL", this.ScenePictureURL);
            this.SetParamSimple(map, prefix + "HeadX", this.HeadX);
            this.SetParamSimple(map, prefix + "HeadY", this.HeadY);
            this.SetParamSimple(map, prefix + "HeadWidth", this.HeadWidth);
            this.SetParamSimple(map, prefix + "HeadHeight", this.HeadHeight);
        }
    }
}

