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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ZoneSellConf : AbstractModel
    {
        
        /// <summary>
        /// 可用区状态。可能的返回值为：0-未上线；1-上线；2-开放；3-停售；4-不展示
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 可用区中文名称
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// 实例类型是否为自定义类型
        /// </summary>
        [JsonProperty("IsCustom")]
        public bool? IsCustom{ get; set; }

        /// <summary>
        /// 是否支持灾备
        /// </summary>
        [JsonProperty("IsSupportDr")]
        public bool? IsSupportDr{ get; set; }

        /// <summary>
        /// 是否支持私有网络
        /// </summary>
        [JsonProperty("IsSupportVpc")]
        public bool? IsSupportVpc{ get; set; }

        /// <summary>
        /// 小时计费实例最大售卖数量
        /// </summary>
        [JsonProperty("HourInstanceSaleMaxNum")]
        public long? HourInstanceSaleMaxNum{ get; set; }

        /// <summary>
        /// 是否为默认可用区
        /// </summary>
        [JsonProperty("IsDefaultZone")]
        public bool? IsDefaultZone{ get; set; }

        /// <summary>
        /// 是否为黑石区
        /// </summary>
        [JsonProperty("IsBm")]
        public bool? IsBm{ get; set; }

        /// <summary>
        /// 支持的付费类型。可能的返回值为：0-包年包月；1-小时计费；2-后付费
        /// </summary>
        [JsonProperty("PayType")]
        public string[] PayType{ get; set; }

        /// <summary>
        /// 数据复制类型。0-异步复制；1-半同步复制；2-强同步复制
        /// </summary>
        [JsonProperty("ProtectMode")]
        public string[] ProtectMode{ get; set; }

        /// <summary>
        /// 可用区名称
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 售卖实例类型数组
        /// </summary>
        [JsonProperty("SellType")]
        public SellType[] SellType{ get; set; }

        /// <summary>
        /// 多可用区信息
        /// </summary>
        [JsonProperty("ZoneConf")]
        public ZoneConf ZoneConf{ get; set; }

        /// <summary>
        /// 可支持的灾备可用区信息
        /// </summary>
        [JsonProperty("DrZone")]
        public string[] DrZone{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamSimple(map, prefix + "IsCustom", this.IsCustom);
            this.SetParamSimple(map, prefix + "IsSupportDr", this.IsSupportDr);
            this.SetParamSimple(map, prefix + "IsSupportVpc", this.IsSupportVpc);
            this.SetParamSimple(map, prefix + "HourInstanceSaleMaxNum", this.HourInstanceSaleMaxNum);
            this.SetParamSimple(map, prefix + "IsDefaultZone", this.IsDefaultZone);
            this.SetParamSimple(map, prefix + "IsBm", this.IsBm);
            this.SetParamArraySimple(map, prefix + "PayType.", this.PayType);
            this.SetParamArraySimple(map, prefix + "ProtectMode.", this.ProtectMode);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamArrayObj(map, prefix + "SellType.", this.SellType);
            this.SetParamObj(map, prefix + "ZoneConf.", this.ZoneConf);
            this.SetParamArraySimple(map, prefix + "DrZone.", this.DrZone);
        }
    }
}

