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

namespace TencentCloud.Cfs.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UnbindAutoSnapshotPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// 需要解绑的文件系统ID列表，用"," 分割，文件系统id 通创建文件系统接口获得
        /// </summary>
        [JsonProperty("FileSystemIds")]
        public string FileSystemIds{ get; set; }

        /// <summary>
        /// 解绑的快照ID，通过创建快照策略接口获得
        /// </summary>
        [JsonProperty("AutoSnapshotPolicyId")]
        public string AutoSnapshotPolicyId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileSystemIds", this.FileSystemIds);
            this.SetParamSimple(map, prefix + "AutoSnapshotPolicyId", this.AutoSnapshotPolicyId);
        }
    }
}

