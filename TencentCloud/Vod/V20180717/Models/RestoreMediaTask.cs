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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RestoreMediaTask : AbstractModel
    {
        
        /// <summary>
        /// 取回任务状态，0表示取回完成，其他值表示取回还未完成。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 提示信息。
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// 文件ID。
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// 文件原始存储类型。
        /// </summary>
        [JsonProperty("OriginalStorageClass")]
        public string OriginalStorageClass{ get; set; }

        /// <summary>
        /// 文件目标存储类型。对于临时取回，目标存储类型与原始存储类型相同。
        /// </summary>
        [JsonProperty("TargetStorageClass")]
        public string TargetStorageClass{ get; set; }

        /// <summary>
        /// 取回模式，取值：
        /// <li>Expedited：极速模式</li>
        /// <li>Standard：标准模式</li>
        /// <li>Bulk：批量模式</li>
        /// </summary>
        [JsonProperty("RestoreTier")]
        public string RestoreTier{ get; set; }

        /// <summary>
        /// 临时取回副本有效期，单位：天。对于永久取回，取值为0。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RestoreDay")]
        public long? RestoreDay{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "OriginalStorageClass", this.OriginalStorageClass);
            this.SetParamSimple(map, prefix + "TargetStorageClass", this.TargetStorageClass);
            this.SetParamSimple(map, prefix + "RestoreTier", this.RestoreTier);
            this.SetParamSimple(map, prefix + "RestoreDay", this.RestoreDay);
        }
    }
}

