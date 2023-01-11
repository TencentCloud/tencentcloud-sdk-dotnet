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

namespace TencentCloud.Tcr.V20190924.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 企业版实例名称
        /// </summary>
        [JsonProperty("RegistryName")]
        public string RegistryName{ get; set; }

        /// <summary>
        /// 企业版实例类型（basic 基础版；standard 标准版；premium 高级版）
        /// </summary>
        [JsonProperty("RegistryType")]
        public string RegistryType{ get; set; }

        /// <summary>
        /// 云标签描述
        /// </summary>
        [JsonProperty("TagSpecification")]
        public TagSpecification TagSpecification{ get; set; }

        /// <summary>
        /// 实例计费类型，0表示按量计费，1表示预付费，默认为按量计费
        /// </summary>
        [JsonProperty("RegistryChargeType")]
        public long? RegistryChargeType{ get; set; }

        /// <summary>
        /// 预付费自动续费标识和购买时长
        /// </summary>
        [JsonProperty("RegistryChargePrepaid")]
        public RegistryChargePrepaid RegistryChargePrepaid{ get; set; }

        /// <summary>
        /// 是否同步TCR云标签至生成的COS Bucket
        /// </summary>
        [JsonProperty("SyncTag")]
        public bool? SyncTag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RegistryName", this.RegistryName);
            this.SetParamSimple(map, prefix + "RegistryType", this.RegistryType);
            this.SetParamObj(map, prefix + "TagSpecification.", this.TagSpecification);
            this.SetParamSimple(map, prefix + "RegistryChargeType", this.RegistryChargeType);
            this.SetParamObj(map, prefix + "RegistryChargePrepaid.", this.RegistryChargePrepaid);
            this.SetParamSimple(map, prefix + "SyncTag", this.SyncTag);
        }
    }
}

