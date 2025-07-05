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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DisassociateInstancesKeyPairsRequest : AbstractModel
    {
        
        /// <summary>
        /// 一个或多个待操作的实例ID，每次请求批量实例的上限为100。<br>可以通过以下方式获取可用的实例ID：
        /// <li>通过登录[控制台](https://console.cloud.tencent.com/cvm/index)查询实例ID。</li>
        /// <li>通过调用接口 [DescribeInstances](https://cloud.tencent.com/document/api/213/15728) ，取返回信息中的 `InstanceId` 获取实例ID。</li>
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// 密钥对ID列表，列表长度上限为100。可以通过以下方式获取可用的密钥ID：
        /// <li>通过登录[控制台](https://console.cloud.tencent.com/cvm/sshkey)查询密钥ID。</li>
        /// <li>通过调用接口 [DescribeKeyPairs](https://cloud.tencent.com/document/api/213/15699) ，取返回信息中的 `KeyId` 获取密钥对ID。</li>
        /// </summary>
        [JsonProperty("KeyIds")]
        public string[] KeyIds{ get; set; }

        /// <summary>
        /// 是否强制关机，默认值为 false。常规场景下，建议手动关机后解绑密钥。取值范围：
        /// <li>true：先执行强制关机，再解绑密钥。</li>
        /// <li>false：不执行强制关机，仅支持对已关机状态实例进行解绑操作。</li>
        /// </summary>
        [JsonProperty("ForceStop")]
        public bool? ForceStop{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamArraySimple(map, prefix + "KeyIds.", this.KeyIds);
            this.SetParamSimple(map, prefix + "ForceStop", this.ForceStop);
        }
    }
}

