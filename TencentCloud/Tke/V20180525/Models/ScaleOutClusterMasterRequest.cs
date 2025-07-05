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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScaleOutClusterMasterRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群实例ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 新建节点参数
        /// </summary>
        [JsonProperty("RunInstancesForNode")]
        public RunInstancesForNode[] RunInstancesForNode{ get; set; }

        /// <summary>
        /// 添加已有节点相关参数
        /// </summary>
        [JsonProperty("ExistedInstancesForNode")]
        public ExistedInstancesForNode[] ExistedInstancesForNode{ get; set; }

        /// <summary>
        /// 实例高级设置
        /// </summary>
        [JsonProperty("InstanceAdvancedSettings")]
        public InstanceAdvancedSettings InstanceAdvancedSettings{ get; set; }

        /// <summary>
        /// 集群master组件自定义参数
        /// </summary>
        [JsonProperty("ExtraArgs")]
        public ClusterExtraArgs ExtraArgs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamArrayObj(map, prefix + "RunInstancesForNode.", this.RunInstancesForNode);
            this.SetParamArrayObj(map, prefix + "ExistedInstancesForNode.", this.ExistedInstancesForNode);
            this.SetParamObj(map, prefix + "InstanceAdvancedSettings.", this.InstanceAdvancedSettings);
            this.SetParamObj(map, prefix + "ExtraArgs.", this.ExtraArgs);
        }
    }
}

