/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Ivld.V20210903.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PersonInfo : AbstractModel
    {
        
        /// <summary>
        /// 公众人物姓名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 公众人物职务
        /// </summary>
        [JsonProperty("Job")]
        public string Job{ get; set; }

        /// <summary>
        /// 首次出现模态，可选值为[1,3]，详细参见AppearIndex定义
        /// </summary>
        [JsonProperty("FirstAppear")]
        public long? FirstAppear{ get; set; }

        /// <summary>
        /// 人物出现信息
        /// </summary>
        [JsonProperty("AppearInfo")]
        public AppearInfo AppearInfo{ get; set; }

        /// <summary>
        /// 人脸在图片中的位置，仅在图片标签任务有效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppearRect")]
        public Rectf AppearRect{ get; set; }

        /// <summary>
        /// 人物的personId
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PersonId")]
        public string PersonId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Job", this.Job);
            this.SetParamSimple(map, prefix + "FirstAppear", this.FirstAppear);
            this.SetParamObj(map, prefix + "AppearInfo.", this.AppearInfo);
            this.SetParamObj(map, prefix + "AppearRect.", this.AppearRect);
            this.SetParamSimple(map, prefix + "PersonId", this.PersonId);
        }
    }
}

