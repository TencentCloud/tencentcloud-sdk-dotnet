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

    public class PersonVisitInfo : AbstractModel
    {
        
        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonProperty("PersonId")]
        public ulong? PersonId{ get; set; }

        /// <summary>
        /// 用户到访ID
        /// </summary>
        [JsonProperty("VisitId")]
        public ulong? VisitId{ get; set; }

        /// <summary>
        /// 到访时间：Unix时间戳
        /// </summary>
        [JsonProperty("InTime")]
        public ulong? InTime{ get; set; }

        /// <summary>
        /// 抓拍到的头像，这里返回的是图片内容的Base64编码
        /// </summary>
        [JsonProperty("CapturedPicture")]
        public string CapturedPicture{ get; set; }

        /// <summary>
        /// 口罩类型：0不戴口罩，1戴口罩
        /// </summary>
        [JsonProperty("MaskType")]
        public ulong? MaskType{ get; set; }

        /// <summary>
        /// 眼镜类型：0不戴眼镜，1普通眼镜 , 2墨镜
        /// </summary>
        [JsonProperty("GlassType")]
        public ulong? GlassType{ get; set; }

        /// <summary>
        /// 发型：0 短发,  1长发
        /// </summary>
        [JsonProperty("HairType")]
        public ulong? HairType{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PersonId", this.PersonId);
            this.SetParamSimple(map, prefix + "VisitId", this.VisitId);
            this.SetParamSimple(map, prefix + "InTime", this.InTime);
            this.SetParamSimple(map, prefix + "CapturedPicture", this.CapturedPicture);
            this.SetParamSimple(map, prefix + "MaskType", this.MaskType);
            this.SetParamSimple(map, prefix + "GlassType", this.GlassType);
            this.SetParamSimple(map, prefix + "HairType", this.HairType);
        }
    }
}

