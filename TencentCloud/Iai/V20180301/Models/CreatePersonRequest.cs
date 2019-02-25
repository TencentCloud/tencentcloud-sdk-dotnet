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

    public class CreatePersonRequest : AbstractModel
    {
        
        /// <summary>
        /// 待加入的人员库ID。
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 人员名称。[1，60]个字符，可修改，可重复。
        /// </summary>
        [JsonProperty("PersonName")]
        public string PersonName{ get; set; }

        /// <summary>
        /// 人员ID，单个腾讯云账号下不可修改，不可重复。支持英文、数字、-%@#&_，长度限制64B。
        /// </summary>
        [JsonProperty("PersonId")]
        public string PersonId{ get; set; }

        /// <summary>
        /// 0代表未填写，1代表男性，2代表女性。
        /// </summary>
        [JsonProperty("Gender")]
        public long? Gender{ get; set; }

        /// <summary>
        /// 人员描述字段内容，key-value。[0，60]个字符，可修改，可重复。
        /// </summary>
        [JsonProperty("PersonExDescriptionInfos")]
        public PersonExDescriptionInfo[] PersonExDescriptionInfos{ get; set; }

        /// <summary>
        /// 图片 base64 数据。
        /// 若图片中包含多张人脸，只选取其中人脸面积最大的人脸。
        /// 支持PNG、JPG、JPEG、BMP，不支持 GIF 图片。
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }

        /// <summary>
        /// 图片的 Url、Image必须提供一个，如果都提供，只使用 Url。
        /// 图片存储于腾讯云的Url可保障更高下载速度和稳定性，建议图片存储于腾讯云。 
        /// 非腾讯云存储的Url速度和稳定性可能受一定影响。
        /// 若图片中包含多张人脸，只选取其中人脸面积最大的人脸。
        /// 支持PNG、JPG、JPEG、BMP，不支持 GIF 图片。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "PersonName", this.PersonName);
            this.SetParamSimple(map, prefix + "PersonId", this.PersonId);
            this.SetParamSimple(map, prefix + "Gender", this.Gender);
            this.SetParamArrayObj(map, prefix + "PersonExDescriptionInfos.", this.PersonExDescriptionInfos);
            this.SetParamSimple(map, prefix + "Image", this.Image);
            this.SetParamSimple(map, prefix + "Url", this.Url);
        }
    }
}

