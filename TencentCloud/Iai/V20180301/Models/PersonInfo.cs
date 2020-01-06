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

    public class PersonInfo : AbstractModel
    {
        
        /// <summary>
        /// 人员名称
        /// </summary>
        [JsonProperty("PersonName")]
        public string PersonName{ get; set; }

        /// <summary>
        /// 人员Id
        /// </summary>
        [JsonProperty("PersonId")]
        public string PersonId{ get; set; }

        /// <summary>
        /// 人员性别
        /// </summary>
        [JsonProperty("Gender")]
        public long? Gender{ get; set; }

        /// <summary>
        /// 人员描述字段内容
        /// </summary>
        [JsonProperty("PersonExDescriptions")]
        public string[] PersonExDescriptions{ get; set; }

        /// <summary>
        /// 包含的人脸照片列表
        /// </summary>
        [JsonProperty("FaceIds")]
        public string[] FaceIds{ get; set; }

        /// <summary>
        /// Group的创建时间和日期 CreationTimestamp。CreationTimestamp 的值是自 Unix 纪元时间到Group创建时间的毫秒数。 
        /// Unix 纪元时间是 1970 年 1 月 1 日星期四，协调世界时 (UTC) 00:00:00。有关更多信息，请参阅 Unix 时间。
        /// </summary>
        [JsonProperty("CreationTimestamp")]
        public ulong? CreationTimestamp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PersonName", this.PersonName);
            this.SetParamSimple(map, prefix + "PersonId", this.PersonId);
            this.SetParamSimple(map, prefix + "Gender", this.Gender);
            this.SetParamArraySimple(map, prefix + "PersonExDescriptions.", this.PersonExDescriptions);
            this.SetParamArraySimple(map, prefix + "FaceIds.", this.FaceIds);
            this.SetParamSimple(map, prefix + "CreationTimestamp", this.CreationTimestamp);
        }
    }
}

