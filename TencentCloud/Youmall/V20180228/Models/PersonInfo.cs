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
        public ulong? Gender{ get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        [JsonProperty("Age")]
        public ulong? Age{ get; set; }

        /// <summary>
        /// 身份类型：0-普通顾客，1~10黑名单，11~20白名单，11店员
        /// </summary>
        [JsonProperty("PersonType")]
        public ulong? PersonType{ get; set; }

        /// <summary>
        /// 人脸图片Url，在有效期内可以访问下载
        /// </summary>
        [JsonProperty("PersonPictureUrl")]
        public string PersonPictureUrl{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PersonId", this.PersonId);
            this.SetParamSimple(map, prefix + "PersonPicture", this.PersonPicture);
            this.SetParamSimple(map, prefix + "Gender", this.Gender);
            this.SetParamSimple(map, prefix + "Age", this.Age);
            this.SetParamSimple(map, prefix + "PersonType", this.PersonType);
            this.SetParamSimple(map, prefix + "PersonPictureUrl", this.PersonPictureUrl);
        }
    }
}

