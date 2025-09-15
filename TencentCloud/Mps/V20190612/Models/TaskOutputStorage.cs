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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskOutputStorage : AbstractModel
    {
        
        /// <summary>
        /// 媒体处理输出对象存储位置的类型，支持：
        /// <li>COS：COS存储</li>
        /// <li>AWS-S3：AWS 存储，只适用于AWS任务，且要求同区域</li>
        /// <li> VOD：点播专业版 </li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 当 Type 为 COS 时有效，则该项为必填，表示媒体处理 COS 输出位置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CosOutputStorage")]
        public CosOutputStorage CosOutputStorage{ get; set; }

        /// <summary>
        /// 当 Type 为 AWS-S3 时有效，则该项为必填，表示媒体处理 AWS S3 输出位置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("S3OutputStorage")]
        public S3OutputStorage S3OutputStorage{ get; set; }

        /// <summary>
        /// 当 Type 为 VOD 时有效，则该项为必填，表示媒体处理 点播专业版 输出位置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VODOutputStorage")]
        public VODOutputStorage VODOutputStorage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "CosOutputStorage.", this.CosOutputStorage);
            this.SetParamObj(map, prefix + "S3OutputStorage.", this.S3OutputStorage);
            this.SetParamObj(map, prefix + "VODOutputStorage.", this.VODOutputStorage);
        }
    }
}

