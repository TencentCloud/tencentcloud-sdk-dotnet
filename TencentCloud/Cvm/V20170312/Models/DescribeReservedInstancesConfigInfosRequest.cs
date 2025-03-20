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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeReservedInstancesConfigInfosRequest : AbstractModel
    {
        
        /// <summary>
        /// zone
        /// 按照预留实例计费可购买的可用区进行过滤。形如：ap-guangzhou-1。
        /// 类型：String
        /// 必选：否
        /// 可选项：各地域可用区列表
        /// 
        /// product-description
        /// 按照预留实例计费的平台描述（即操作系统）进行过滤。形如：linux。
        /// 类型：String
        /// 必选：否
        /// 可选项：linux
        /// 
        /// duration
        /// 按照预留实例计费有效期，即预留实例计费购买时长进行过滤。形如：31536000。
        /// 类型：Integer
        /// 计量单位：秒
        /// 必选：否
        /// 可选项：31536000 (1年)
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

