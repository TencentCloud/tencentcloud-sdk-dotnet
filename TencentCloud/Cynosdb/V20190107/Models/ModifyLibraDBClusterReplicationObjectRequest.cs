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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyLibraDBClusterReplicationObjectRequest : AbstractModel
    {
        
        /// <summary>
        /// 分析集群ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 只读分析引擎实例 ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 映射模式
        /// </summary>
        [JsonProperty("ForceDefaultMapRule")]
        public string ForceDefaultMapRule{ get; set; }

        /// <summary>
        /// 同步对象
        /// </summary>
        [JsonProperty("Objects")]
        public ReplicationObject[] Objects{ get; set; }

        /// <summary>
        /// 自动映射规则
        /// </summary>
        [JsonProperty("AutoMapRules")]
        public AutoMapRule[] AutoMapRules{ get; set; }

        /// <summary>
        /// 是否按照最新映射规则刷新存量映射关系
        /// </summary>
        [JsonProperty("RefreshMapping")]
        public bool? RefreshMapping{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ForceDefaultMapRule", this.ForceDefaultMapRule);
            this.SetParamArrayObj(map, prefix + "Objects.", this.Objects);
            this.SetParamArrayObj(map, prefix + "AutoMapRules.", this.AutoMapRules);
            this.SetParamSimple(map, prefix + "RefreshMapping", this.RefreshMapping);
        }
    }
}

