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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateVpcEndPointServiceRequest : AbstractModel
    {
        
        /// <summary>
        /// VPC实例ID。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 终端节点服务名称。
        /// </summary>
        [JsonProperty("EndPointServiceName")]
        public string EndPointServiceName{ get; set; }

        /// <summary>
        /// 是否自动接受。
        /// </summary>
        [JsonProperty("AutoAcceptFlag")]
        public bool? AutoAcceptFlag{ get; set; }

        /// <summary>
        /// 后端服务ID，比如lb-xxx。
        /// </summary>
        [JsonProperty("ServiceInstanceId")]
        public string ServiceInstanceId{ get; set; }

        /// <summary>
        /// 是否是PassService类型。
        /// </summary>
        [JsonProperty("IsPassService")]
        public bool? IsPassService{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "EndPointServiceName", this.EndPointServiceName);
            this.SetParamSimple(map, prefix + "AutoAcceptFlag", this.AutoAcceptFlag);
            this.SetParamSimple(map, prefix + "ServiceInstanceId", this.ServiceInstanceId);
            this.SetParamSimple(map, prefix + "IsPassService", this.IsPassService);
        }
    }
}

