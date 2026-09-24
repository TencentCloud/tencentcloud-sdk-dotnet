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

namespace TencentCloud.Ioa.V20220601.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UnbindVirtualAccountsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Comment: 虚拟组id;Required:true</p>
        /// </summary>
        [JsonProperty("VirtualGroupId")]
        public long? VirtualGroupId{ get; set; }

        /// <summary>
        /// <p>Comment: 要取消绑定的账户Id集合，这里的Id指的是DescribeLocalAccountsData结构体里返回的Id;Required:true</p>
        /// </summary>
        [JsonProperty("AccountIdList")]
        public long?[] AccountIdList{ get; set; }

        /// <summary>
        /// <p>Comment: 要取消绑定的账户(目录MenuId+登录账号UserId)集合，与AccountIdList二选一或并用，查不到的账号会被跳过;Required:false</p>
        /// </summary>
        [JsonProperty("AccountUserList")]
        public AccountUserIdItem[] AccountUserList{ get; set; }

        /// <summary>
        /// Comment: 管理域实例ID，用于CAM管理域权限分配。若企业未进行管理域的划分，可直接传入根域"1"，此时表示针对当前企业的全部设备和账号进行接口CRUD，具体CRUD的影响范围限制于相应接口的入参。
        /// </summary>
        [JsonProperty("DomainInstanceId")]
        public string DomainInstanceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VirtualGroupId", this.VirtualGroupId);
            this.SetParamArraySimple(map, prefix + "AccountIdList.", this.AccountIdList);
            this.SetParamArrayObj(map, prefix + "AccountUserList.", this.AccountUserList);
            this.SetParamSimple(map, prefix + "DomainInstanceId", this.DomainInstanceId);
        }
    }
}

