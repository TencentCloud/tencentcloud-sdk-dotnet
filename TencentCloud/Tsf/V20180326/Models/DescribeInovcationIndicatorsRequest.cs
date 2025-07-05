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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInovcationIndicatorsRequest : AbstractModel
    {
        
        /// <summary>
        /// 维度
        /// </summary>
        [JsonProperty("Dimension")]
        public string Dimension{ get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 命名空间ID
        /// </summary>
        [JsonProperty("NamespaceId")]
        public string NamespaceId{ get; set; }

        /// <summary>
        /// 微服务ID
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }

        /// <summary>
        /// 调用方服务名
        /// </summary>
        [JsonProperty("CallerServiceName")]
        public string CallerServiceName{ get; set; }

        /// <summary>
        /// 被调方服务名
        /// </summary>
        [JsonProperty("CalleeServiceName")]
        public string CalleeServiceName{ get; set; }

        /// <summary>
        /// 调用方接口名
        /// </summary>
        [JsonProperty("CallerInterfaceName")]
        public string CallerInterfaceName{ get; set; }

        /// <summary>
        /// 被调方接口名
        /// </summary>
        [JsonProperty("CalleeInterfaceName")]
        public string CalleeInterfaceName{ get; set; }

        /// <summary>
        /// 应用ID
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// 部署组ID
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Dimension", this.Dimension);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "NamespaceId", this.NamespaceId);
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "CallerServiceName", this.CallerServiceName);
            this.SetParamSimple(map, prefix + "CalleeServiceName", this.CalleeServiceName);
            this.SetParamSimple(map, prefix + "CallerInterfaceName", this.CallerInterfaceName);
            this.SetParamSimple(map, prefix + "CalleeInterfaceName", this.CalleeInterfaceName);
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
        }
    }
}

