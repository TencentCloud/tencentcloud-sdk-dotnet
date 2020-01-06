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
        /// 图片 base64 数据，base64 编码后大小不可超过5M。
        /// 支持PNG、JPG、JPEG、BMP，不支持 GIF 图片。
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }

        /// <summary>
        /// 图片的 Url 。对应图片 base64 编码后大小不可超过5M。
        /// Url、Image必须提供一个，如果都提供，只使用 Url。  
        /// 图片存储于腾讯云的Url可保障更高下载速度和稳定性，建议图片存储于腾讯云。 
        /// 非腾讯云存储的Url速度和稳定性可能受一定影响。
        /// 支持PNG、JPG、JPEG、BMP，不支持 GIF 图片。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 此参数用于控制判断 Image 或 Url 中图片包含的人脸，是否在人员库中已有疑似的同一人。 
        /// 如果判断为已有相同人在人员库中，则不会创建新的人员，返回疑似同一人的人员信息。 
        /// 如果判断没有，则完成创建人员。 
        /// 0: 不进行判断，无论是否有疑似同一人在库中均完成入库； 
        /// 1:较低的同一人判断要求（百一误识别率）； 
        /// 2: 一般的同一人判断要求（千一误识别率）； 
        /// 3: 较高的同一人判断要求（万一误识别率）； 
        /// 4: 很高的同一人判断要求（十万一误识别率）。 
        /// 默认 0。  
        /// 注： 要求越高，则疑似同一人的概率越小。不同要求对应的误识别率仅为参考值，您可以根据实际情况调整。
        /// </summary>
        [JsonProperty("UniquePersonControl")]
        public ulong? UniquePersonControl{ get; set; }

        /// <summary>
        /// 图片质量控制。 
        /// 0: 不进行控制； 
        /// 1:较低的质量要求，图像存在非常模糊，眼睛鼻子嘴巴遮挡至少其中一种或多种的情况； 
        /// 2: 一般的质量要求，图像存在偏亮，偏暗，模糊或一般模糊，眉毛遮挡，脸颊遮挡，下巴遮挡，至少其中三种的情况； 
        /// 3: 较高的质量要求，图像存在偏亮，偏暗，一般模糊，眉毛遮挡，脸颊遮挡，下巴遮挡，其中一到两种的情况； 
        /// 4: 很高的质量要求，各个维度均为最好或最多在某一维度上存在轻微问题； 
        /// 默认 0。 
        /// 若图片质量不满足要求，则返回结果中会提示图片质量检测不符要求。
        /// </summary>
        [JsonProperty("QualityControl")]
        public ulong? QualityControl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
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
            this.SetParamSimple(map, prefix + "UniquePersonControl", this.UniquePersonControl);
            this.SetParamSimple(map, prefix + "QualityControl", this.QualityControl);
        }
    }
}

