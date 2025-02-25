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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CloudBaseRunEmptyDirVolumeSource : AbstractModel
    {
        
        /// <summary>
        /// 启用emptydir数据卷
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableEmptyDirVolume")]
        public bool? EnableEmptyDirVolume{ get; set; }

        /// <summary>
        /// "","Memory","HugePages"
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Medium")]
        public string Medium{ get; set; }

        /// <summary>
        /// emptydir数据卷大小
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SizeLimit")]
        public string SizeLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnableEmptyDirVolume", this.EnableEmptyDirVolume);
            this.SetParamSimple(map, prefix + "Medium", this.Medium);
            this.SetParamSimple(map, prefix + "SizeLimit", this.SizeLimit);
        }
    }
}

