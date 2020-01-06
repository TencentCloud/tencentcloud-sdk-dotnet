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

namespace TencentCloud.Bm.V20180423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSpotDeviceRequest : AbstractModel
    {
        
        /// <summary>
        /// 可用区名称。如ap-guangzhou-bls-1, 通过DescribeRegions获取
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 计算单元类型, 如v3.c2.medium，更详细的ComputeType参考[竞价实例产品文档](https://cloud.tencent.com/document/product/386/30256)
        /// </summary>
        [JsonProperty("ComputeType")]
        public string ComputeType{ get; set; }

        /// <summary>
        /// 操作系统类型ID
        /// </summary>
        [JsonProperty("OsTypeId")]
        public ulong? OsTypeId{ get; set; }

        /// <summary>
        /// 私有网络ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 子网ID
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 购买的计算单元个数
        /// </summary>
        [JsonProperty("GoodsNum")]
        public ulong? GoodsNum{ get; set; }

        /// <summary>
        /// 出价策略。可取值为SpotWithPriceLimit和SpotAsPriceGo。SpotWithPriceLimit，用户设置价格上限，需要传SpotPriceLimit参数， 如果市场价高于用户的指定价格，则购买不成功;  SpotAsPriceGo 是随市场价的策略。
        /// </summary>
        [JsonProperty("SpotStrategy")]
        public string SpotStrategy{ get; set; }

        /// <summary>
        /// 用户设置的价格。当为SpotWithPriceLimit竞价策略时有效
        /// </summary>
        [JsonProperty("SpotPriceLimit")]
        public float? SpotPriceLimit{ get; set; }

        /// <summary>
        /// 设置竞价实例密码。可选参数，没有指定会生成随机密码
        /// </summary>
        [JsonProperty("Passwd")]
        public string Passwd{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "ComputeType", this.ComputeType);
            this.SetParamSimple(map, prefix + "OsTypeId", this.OsTypeId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "GoodsNum", this.GoodsNum);
            this.SetParamSimple(map, prefix + "SpotStrategy", this.SpotStrategy);
            this.SetParamSimple(map, prefix + "SpotPriceLimit", this.SpotPriceLimit);
            this.SetParamSimple(map, prefix + "Passwd", this.Passwd);
        }
    }
}

