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

namespace TencentCloud.Iai.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FaceShape : AbstractModel
    {
        
        /// <summary>
        /// 描述脸型轮廓的 21 点。
        /// </summary>
        [JsonProperty("FaceProfile")]
        public Point[] FaceProfile{ get; set; }

        /// <summary>
        /// 描述左侧眼睛轮廓的 8 点。
        /// </summary>
        [JsonProperty("LeftEye")]
        public Point[] LeftEye{ get; set; }

        /// <summary>
        /// 描述右侧眼睛轮廓的 8 点。
        /// </summary>
        [JsonProperty("RightEye")]
        public Point[] RightEye{ get; set; }

        /// <summary>
        /// 描述左侧眉毛轮廓的 8 点。
        /// </summary>
        [JsonProperty("LeftEyeBrow")]
        public Point[] LeftEyeBrow{ get; set; }

        /// <summary>
        /// 描述右侧眉毛轮廓的 8 点。
        /// </summary>
        [JsonProperty("RightEyeBrow")]
        public Point[] RightEyeBrow{ get; set; }

        /// <summary>
        /// 描述嘴巴轮廓的 22 点。
        /// </summary>
        [JsonProperty("Mouth")]
        public Point[] Mouth{ get; set; }

        /// <summary>
        /// 描述鼻子轮廓的 13 点。
        /// </summary>
        [JsonProperty("Nose")]
        public Point[] Nose{ get; set; }

        /// <summary>
        /// 左瞳孔轮廓的 1 个点。
        /// </summary>
        [JsonProperty("LeftPupil")]
        public Point[] LeftPupil{ get; set; }

        /// <summary>
        /// 右瞳孔轮廓的 1 个点。
        /// </summary>
        [JsonProperty("RightPupil")]
        public Point[] RightPupil{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "FaceProfile.", this.FaceProfile);
            this.SetParamArrayObj(map, prefix + "LeftEye.", this.LeftEye);
            this.SetParamArrayObj(map, prefix + "RightEye.", this.RightEye);
            this.SetParamArrayObj(map, prefix + "LeftEyeBrow.", this.LeftEyeBrow);
            this.SetParamArrayObj(map, prefix + "RightEyeBrow.", this.RightEyeBrow);
            this.SetParamArrayObj(map, prefix + "Mouth.", this.Mouth);
            this.SetParamArrayObj(map, prefix + "Nose.", this.Nose);
            this.SetParamArrayObj(map, prefix + "LeftPupil.", this.LeftPupil);
            this.SetParamArrayObj(map, prefix + "RightPupil.", this.RightPupil);
        }
    }
}

