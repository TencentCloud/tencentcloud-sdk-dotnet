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

    public class ModifyIPv6AddressesAttributesRequest : AbstractModel
    {
        
        /// <summary>
        /// 弹性公网IPv6唯一ID列表。可以使用[DescribeIPv6Addresses](https://cloud.tencent.com/document/api/215/113677)接口获取IPv6AddressIds。
        /// </summary>
        [JsonProperty("IPv6AddressIds")]
        public string[] IPv6AddressIds{ get; set; }

        /// <summary>
        /// 弹性公网IPv6地址名称，长度上限为128个字符，允许使用大小写字母、汉字、数字、连字符"-"和下划线"_"，不能包含空格。
        /// </summary>
        [JsonProperty("IPv6AddressName")]
        public string IPv6AddressName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "IPv6AddressIds.", this.IPv6AddressIds);
            this.SetParamSimple(map, prefix + "IPv6AddressName", this.IPv6AddressName);
        }
    }
}

