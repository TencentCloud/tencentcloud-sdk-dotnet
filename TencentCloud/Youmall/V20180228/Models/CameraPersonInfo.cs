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

    public class CameraPersonInfo : AbstractModel
    {
        
        /// <summary>
        /// 临时id，还未生成face id时返回
        /// </summary>
        [JsonProperty("TempId")]
        public string TempId{ get; set; }

        /// <summary>
        /// 人脸face id
        /// </summary>
        [JsonProperty("FaceId")]
        public long? FaceId{ get; set; }

        /// <summary>
        /// 确定当次返回的哪个id有效，1-FaceId，2-TempId
        /// </summary>
        [JsonProperty("IdType")]
        public long? IdType{ get; set; }

        /// <summary>
        /// 当次抓拍到的人脸图片base编码
        /// </summary>
        [JsonProperty("FacePic")]
        public string FacePic{ get; set; }

        /// <summary>
        /// 当次抓拍时间戳
        /// </summary>
        [JsonProperty("Time")]
        public long? Time{ get; set; }

        /// <summary>
        /// 当前的person基本信息，图片以FacePic为准，结构体内未填
        /// </summary>
        [JsonProperty("PersonInfo")]
        public PersonInfo PersonInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TempId", this.TempId);
            this.SetParamSimple(map, prefix + "FaceId", this.FaceId);
            this.SetParamSimple(map, prefix + "IdType", this.IdType);
            this.SetParamSimple(map, prefix + "FacePic", this.FacePic);
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamObj(map, prefix + "PersonInfo.", this.PersonInfo);
        }
    }
}

