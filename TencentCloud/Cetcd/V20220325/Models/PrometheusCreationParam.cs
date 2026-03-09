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

namespace TencentCloud.Cetcd.V20220325.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PrometheusCreationParam : AbstractModel
    {
        
        /// <summary>
        /// 子网ID
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 保存时长，只支持天单位
        /// 12d = 12天
        /// </summary>
        [JsonProperty("DataRetention")]
        public long? DataRetention{ get; set; }

        /// <summary>
        /// grafana用户名
        /// </summary>
        [JsonProperty("GrafanaUserName")]
        public string GrafanaUserName{ get; set; }

        /// <summary>
        /// grafana密码
        /// </summary>
        [JsonProperty("GrafanaPassword")]
        public string GrafanaPassword{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "DataRetention", this.DataRetention);
            this.SetParamSimple(map, prefix + "GrafanaUserName", this.GrafanaUserName);
            this.SetParamSimple(map, prefix + "GrafanaPassword", this.GrafanaPassword);
        }
    }
}

