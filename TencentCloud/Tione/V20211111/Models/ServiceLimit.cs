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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServiceLimit : AbstractModel
    {
        
        /// <summary>
        /// 是否开启实例层面限流限速，true or false。true 则 InstanceRpsLimit 必填， false 则 InstanceRpsLimit 不生效
        /// </summary>
        [JsonProperty("EnableInstanceRpsLimit")]
        public bool? EnableInstanceRpsLimit{ get; set; }

        /// <summary>
        /// 每个服务实例的 request per second 限速, 0 为不限流
        /// </summary>
        [JsonProperty("InstanceRpsLimit")]
        public long? InstanceRpsLimit{ get; set; }

        /// <summary>
        /// 是否开启单实例最大并发数限制，true or false。true 则 InstanceReqLimit 必填， false 则 InstanceReqLimit 不生效
        /// </summary>
        [JsonProperty("EnableInstanceReqLimit")]
        public bool? EnableInstanceReqLimit{ get; set; }

        /// <summary>
        /// 每个服务实例的最大并发
        /// </summary>
        [JsonProperty("InstanceReqLimit")]
        public long? InstanceReqLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnableInstanceRpsLimit", this.EnableInstanceRpsLimit);
            this.SetParamSimple(map, prefix + "InstanceRpsLimit", this.InstanceRpsLimit);
            this.SetParamSimple(map, prefix + "EnableInstanceReqLimit", this.EnableInstanceReqLimit);
            this.SetParamSimple(map, prefix + "InstanceReqLimit", this.InstanceReqLimit);
        }
    }
}

