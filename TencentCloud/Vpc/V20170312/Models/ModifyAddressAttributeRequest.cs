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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAddressAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// 标识 EIP 的唯一 ID。EIP 唯一 ID 形如：`eip-11112222`。可以使用[DescribeAddresses](https://cloud.tencent.com/document/product/215/16702)接口获取AddressId。
        /// </summary>
        [JsonProperty("AddressId")]
        public string AddressId{ get; set; }

        /// <summary>
        /// 修改后的 EIP 名称。长度上限为128个字符，允许使用大小写字母、汉字、数字、连字符"-"和下划线"\_"，不能包含空格。
        /// </summary>
        [JsonProperty("AddressName")]
        public string AddressName{ get; set; }

        /// <summary>
        /// 设定EIP是否直通，"TRUE"表示直通，"FALSE"表示非直通。
        /// 注意：该参数仅对 EIP 直通功能可见的用户可以设定，EIP 必须为绑定状态，绑定的对象为 CVM 。
        /// </summary>
        [JsonProperty("EipDirectConnection")]
        public string EipDirectConnection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AddressId", this.AddressId);
            this.SetParamSimple(map, prefix + "AddressName", this.AddressName);
            this.SetParamSimple(map, prefix + "EipDirectConnection", this.EipDirectConnection);
        }
    }
}

