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

namespace TencentCloud.Privatedns.V20201028.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateEndPointAndEndPointServiceRequest : AbstractModel
    {
        
        /// <summary>
        /// VPC实例ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 是否自动接受
        /// </summary>
        [JsonProperty("AutoAcceptFlag")]
        public bool? AutoAcceptFlag{ get; set; }

        /// <summary>
        /// 后端服务ID
        /// </summary>
        [JsonProperty("ServiceInstanceId")]
        public string ServiceInstanceId{ get; set; }

        /// <summary>
        /// 终端节点名称
        /// </summary>
        [JsonProperty("EndPointName")]
        public string EndPointName{ get; set; }

        /// <summary>
        /// 终端节点地域，必须要和终端节点服务所属地域一致
        /// </summary>
        [JsonProperty("EndPointRegion")]
        public string EndPointRegion{ get; set; }

        /// <summary>
        /// 终端节点服务名称
        /// </summary>
        [JsonProperty("EndPointServiceName")]
        public string EndPointServiceName{ get; set; }

        /// <summary>
        /// 挂载的PAAS服务类型，CLB,CDB,CRS
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// 终端节点ip数量
        /// </summary>
        [JsonProperty("IpNum")]
        public long? IpNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "AutoAcceptFlag", this.AutoAcceptFlag);
            this.SetParamSimple(map, prefix + "ServiceInstanceId", this.ServiceInstanceId);
            this.SetParamSimple(map, prefix + "EndPointName", this.EndPointName);
            this.SetParamSimple(map, prefix + "EndPointRegion", this.EndPointRegion);
            this.SetParamSimple(map, prefix + "EndPointServiceName", this.EndPointServiceName);
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamSimple(map, prefix + "IpNum", this.IpNum);
        }
    }
}

