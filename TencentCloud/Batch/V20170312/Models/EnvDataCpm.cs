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

namespace TencentCloud.Batch.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EnvDataCpm : AbstractModel
    {
        
        /// <summary>
        /// 黑石可用区列表。可通过黑石[DescribeRegions](https://cloud.tencent.com/document/api/386/33564)接口查询。目前仅支持一个可用区。
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }

        /// <summary>
        /// 黑石计算单元类型列表。如v3.c2.medium，更详细的ComputeType参考[黑石竞价实例产品文档](https://cloud.tencent.com/document/product/386/30256)。目前仅支持一个计算单元类型。
        /// </summary>
        [JsonProperty("ComputeTypes")]
        public string[] ComputeTypes{ get; set; }

        /// <summary>
        /// 黑石操作系统类型ID。
        /// </summary>
        [JsonProperty("OsTypeId")]
        public ulong? OsTypeId{ get; set; }

        /// <summary>
        /// 黑石VPC列表，目前仅支持一个VPC。
        /// </summary>
        [JsonProperty("VirtualPrivateClouds")]
        public CpmVirtualPrivateCloud[] VirtualPrivateClouds{ get; set; }

        /// <summary>
        /// DeployType参数值为fast时，将选取黑石预部署机器发货，发货快。如果无此参数，则选取黑石常规机器发货。
        /// </summary>
        [JsonProperty("DeployType")]
        public string DeployType{ get; set; }

        /// <summary>
        /// 出价策略。默认取值为SpotAsPriceGo，表示出价方式为随市场价的策略。目前只可取值SpotAsPriceGo。
        /// </summary>
        [JsonProperty("SpotStrategy")]
        public string SpotStrategy{ get; set; }

        /// <summary>
        /// 设置黑石竞价实例密码。若不指定会生成随机密码，可到站内信中查看。
        /// </summary>
        [JsonProperty("Passwd")]
        public string Passwd{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Zones.", this.Zones);
            this.SetParamArraySimple(map, prefix + "ComputeTypes.", this.ComputeTypes);
            this.SetParamSimple(map, prefix + "OsTypeId", this.OsTypeId);
            this.SetParamArrayObj(map, prefix + "VirtualPrivateClouds.", this.VirtualPrivateClouds);
            this.SetParamSimple(map, prefix + "DeployType", this.DeployType);
            this.SetParamSimple(map, prefix + "SpotStrategy", this.SpotStrategy);
            this.SetParamSimple(map, prefix + "Passwd", this.Passwd);
        }
    }
}

