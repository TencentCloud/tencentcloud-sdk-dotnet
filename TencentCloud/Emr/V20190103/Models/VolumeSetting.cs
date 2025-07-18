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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VolumeSetting : AbstractModel
    {
        
        /// <summary>
        /// 数据卷类型
        /// <li>HOST_PATH表示支持本机路径</li>
        /// <li>NEW_PVC表示新建PVC</li>
        /// 组件角色支持的数据卷类型可参考 EMR on TKE 集群部署说明：[部署说明](https://cloud.tencent.com/document/product/589/94254)
        /// </summary>
        [JsonProperty("VolumeType")]
        public string VolumeType{ get; set; }

        /// <summary>
        /// 主机路径信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HostPath")]
        public HostPathVolumeSource HostPath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VolumeType", this.VolumeType);
            this.SetParamObj(map, prefix + "HostPath.", this.HostPath);
        }
    }
}

