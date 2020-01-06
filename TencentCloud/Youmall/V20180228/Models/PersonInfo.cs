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

    public class PersonInfo : AbstractModel
    {
        
        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonProperty("PersonId")]
        public ulong? PersonId{ get; set; }

        /// <summary>
        /// 人脸图片Base64内容，已弃用，返回默认空值
        /// </summary>
        [JsonProperty("PersonPicture")]
        public string PersonPicture{ get; set; }

        /// <summary>
        /// 性别：0男1女
        /// </summary>
        [JsonProperty("Gender")]
        public long? Gender{ get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        [JsonProperty("Age")]
        public long? Age{ get; set; }

        /// <summary>
        /// 身份类型（0表示普通顾客，1 白名单，2 表示黑名单）
        /// </summary>
        [JsonProperty("PersonType")]
        public long? PersonType{ get; set; }

        /// <summary>
        /// 人脸图片Url，在有效期内可以访问下载
        /// </summary>
        [JsonProperty("PersonPictureUrl")]
        public string PersonPictureUrl{ get; set; }

        /// <summary>
        /// 身份子类型:
        /// PersonType=0时(普通顾客)，0普通顾客
        /// PersonType=1时(白名单)，0店员，1商场人员，2其他类型人员，3区域经理，4注册用户，5VIP用户
        /// PersonType=2时(黑名单)，0普通黑名单，1小偷)
        /// </summary>
        [JsonProperty("PersonSubType")]
        public long? PersonSubType{ get; set; }

        /// <summary>
        /// 到访次数，-1表示未知
        /// </summary>
        [JsonProperty("VisitTimes")]
        public long? VisitTimes{ get; set; }

        /// <summary>
        /// 到访天数，-1表示未知
        /// </summary>
        [JsonProperty("VisitDays")]
        public long? VisitDays{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PersonId", this.PersonId);
            this.SetParamSimple(map, prefix + "PersonPicture", this.PersonPicture);
            this.SetParamSimple(map, prefix + "Gender", this.Gender);
            this.SetParamSimple(map, prefix + "Age", this.Age);
            this.SetParamSimple(map, prefix + "PersonType", this.PersonType);
            this.SetParamSimple(map, prefix + "PersonPictureUrl", this.PersonPictureUrl);
            this.SetParamSimple(map, prefix + "PersonSubType", this.PersonSubType);
            this.SetParamSimple(map, prefix + "VisitTimes", this.VisitTimes);
            this.SetParamSimple(map, prefix + "VisitDays", this.VisitDays);
        }
    }
}

