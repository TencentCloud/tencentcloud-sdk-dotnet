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

namespace TencentCloud.Tci.V20190318.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreatePersonRequest : AbstractModel
    {
        
        /// <summary>
        /// 人员库唯一标识符
        /// </summary>
        [JsonProperty("LibraryId")]
        public string LibraryId{ get; set; }

        /// <summary>
        /// 人员名称
        /// </summary>
        [JsonProperty("PersonName")]
        public string PersonName{ get; set; }

        /// <summary>
        /// 图片数据 base64 字符串，与 Urls 参数选择一个输入
        /// </summary>
        [JsonProperty("Images")]
        public string[] Images{ get; set; }

        /// <summary>
        /// 人员工作号码
        /// </summary>
        [JsonProperty("JobNumber")]
        public string JobNumber{ get; set; }

        /// <summary>
        /// 人员邮箱
        /// </summary>
        [JsonProperty("Mail")]
        public string Mail{ get; set; }

        /// <summary>
        /// 人员性别，0：未知 1：男性，2：女性
        /// </summary>
        [JsonProperty("Male")]
        public long? Male{ get; set; }

        /// <summary>
        /// 自定义人员 ID，注意不能使用 tci_person_ 前缀
        /// </summary>
        [JsonProperty("PersonId")]
        public string PersonId{ get; set; }

        /// <summary>
        /// 人员电话号码
        /// </summary>
        [JsonProperty("PhoneNumber")]
        public string PhoneNumber{ get; set; }

        /// <summary>
        /// 人员学生号码
        /// </summary>
        [JsonProperty("StudentNumber")]
        public string StudentNumber{ get; set; }

        /// <summary>
        /// 图片下载地址，与 Images 参数选择一个输入
        /// </summary>
        [JsonProperty("Urls")]
        public string[] Urls{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LibraryId", this.LibraryId);
            this.SetParamSimple(map, prefix + "PersonName", this.PersonName);
            this.SetParamArraySimple(map, prefix + "Images.", this.Images);
            this.SetParamSimple(map, prefix + "JobNumber", this.JobNumber);
            this.SetParamSimple(map, prefix + "Mail", this.Mail);
            this.SetParamSimple(map, prefix + "Male", this.Male);
            this.SetParamSimple(map, prefix + "PersonId", this.PersonId);
            this.SetParamSimple(map, prefix + "PhoneNumber", this.PhoneNumber);
            this.SetParamSimple(map, prefix + "StudentNumber", this.StudentNumber);
            this.SetParamArraySimple(map, prefix + "Urls.", this.Urls);
        }
    }
}

