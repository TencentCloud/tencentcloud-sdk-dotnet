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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyReverseShellSystemPolicyConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>集团账号的成员id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>内网告警展示</p>
        /// </summary>
        [JsonProperty("InnerNetAlarmShow")]
        public bool? InnerNetAlarmShow{ get; set; }

        /// <summary>
        /// <p>内网ip展示</p>
        /// </summary>
        [JsonProperty("InnerIPShow")]
        public bool? InnerIPShow{ get; set; }

        /// <summary>
        /// <p>主机范围：0-指定 1-全部 2-专业版 3-旗舰版 4-专业+旗舰</p>
        /// </summary>
        [JsonProperty("CWPScope")]
        public long? CWPScope{ get; set; }

        /// <summary>
        /// <p>指定主机列表（CWPScope=0时使用）</p>
        /// </summary>
        [JsonProperty("InstanceIDsWithAppId")]
        public InstanceIDWithAppIdItem[] InstanceIDsWithAppId{ get; set; }

        /// <summary>
        /// <p>排除主机列表</p>
        /// </summary>
        [JsonProperty("ExcludeInstanceIDsWithAppId")]
        public InstanceIDWithAppIdItem[] ExcludeInstanceIDsWithAppId{ get; set; }

        /// <summary>
        /// <p>标签ID列表</p>
        /// </summary>
        [JsonProperty("TagIDs")]
        public string[] TagIDs{ get; set; }

        /// <summary>
        /// <p>容器范围：0-指定集群 1-全部集群</p>
        /// </summary>
        [JsonProperty("TCSSScope")]
        public long? TCSSScope{ get; set; }

        /// <summary>
        /// <p>指定集群列表（TCSSScope=0时使用）</p>
        /// </summary>
        [JsonProperty("ClusterIDsWithAppId")]
        public ClusterIDWithAppIdItem[] ClusterIDsWithAppId{ get; set; }

        /// <summary>
        /// <p>排除集群列表</p>
        /// </summary>
        [JsonProperty("ExcludeClusterIDsWithAppId")]
        public ClusterIDWithAppIdItem[] ExcludeClusterIDsWithAppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamSimple(map, prefix + "InnerNetAlarmShow", this.InnerNetAlarmShow);
            this.SetParamSimple(map, prefix + "InnerIPShow", this.InnerIPShow);
            this.SetParamSimple(map, prefix + "CWPScope", this.CWPScope);
            this.SetParamArrayObj(map, prefix + "InstanceIDsWithAppId.", this.InstanceIDsWithAppId);
            this.SetParamArrayObj(map, prefix + "ExcludeInstanceIDsWithAppId.", this.ExcludeInstanceIDsWithAppId);
            this.SetParamArraySimple(map, prefix + "TagIDs.", this.TagIDs);
            this.SetParamSimple(map, prefix + "TCSSScope", this.TCSSScope);
            this.SetParamArrayObj(map, prefix + "ClusterIDsWithAppId.", this.ClusterIDsWithAppId);
            this.SetParamArrayObj(map, prefix + "ExcludeClusterIDsWithAppId.", this.ExcludeClusterIDsWithAppId);
        }
    }
}

