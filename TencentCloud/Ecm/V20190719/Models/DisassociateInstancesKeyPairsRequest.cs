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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DisassociateInstancesKeyPairsRequest : AbstractModel
    {
        
        /// <summary>
        /// 可以通过以下方式获取可用的实例ID：
        /// 通过登录控制台查询实例ID。
        /// 通过调用接口 DescribeInstances ，取返回信息中的 InstanceId 获取实例ID。
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// 密钥对ID列表，每次请求批量密钥对的上限为100。密钥对ID形如：skey-11112222。
        /// 
        /// 可以通过以下方式获取可用的密钥ID：
        /// 通过登录控制台查询密钥ID。
        /// 通过调用接口 DescribeKeyPairs ，取返回信息中的 KeyId 获取密钥对ID。
        /// </summary>
        [JsonProperty("KeyIds")]
        public string[] KeyIds{ get; set; }

        /// <summary>
        /// 是否对运行中的实例选择强制关机。建议对运行中的实例先手动关机，然后再解绑密钥。取值范围：
        /// TRUE：表示在正常关机失败后进行强制关机。
        /// FALSE：表示在正常关机失败后不进行强制关机。
        /// 
        /// 默认取值：FALSE。
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

