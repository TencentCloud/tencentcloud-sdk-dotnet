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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceDetail : AbstractModel
    {
        
        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例类型（0 公共实例 1 标准企业实例 2新企业实例3新公共实例）
        /// </summary>
        [JsonProperty("InstanceType")]
        public long? InstanceType{ get; set; }

        /// <summary>
        /// 地域字母缩写
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 区域全拼
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 支持设备总数
        /// </summary>
        [JsonProperty("TotalDeviceNum")]
        public long? TotalDeviceNum{ get; set; }

        /// <summary>
        /// 已注册设备数
        /// </summary>
        [JsonProperty("UsedDeviceNum")]
        public long? UsedDeviceNum{ get; set; }

        /// <summary>
        /// 项目数
        /// </summary>
        [JsonProperty("ProjectNum")]
        public long? ProjectNum{ get; set; }

        /// <summary>
        /// 产品数
        /// </summary>
        [JsonProperty("ProductNum")]
        public long? ProductNum{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 过期时间，公共实例过期时间 0001-01-01T00:00:00Z，公共实例是永久有效
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 总设备数
        /// </summary>
        [JsonProperty("TotalDevice")]
        public long? TotalDevice{ get; set; }

        /// <summary>
        /// 激活设备数
        /// </summary>
        [JsonProperty("ActivateDevice")]
        public long? ActivateDevice{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 实例状态
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 消息上下行配置TPS
        /// </summary>
        [JsonProperty("UpDownTPS")]
        public long? UpDownTPS{ get; set; }

        /// <summary>
        /// 当前消息上下行TPS
        /// </summary>
        [JsonProperty("UpDownCurrentTPS")]
        public long? UpDownCurrentTPS{ get; set; }

        /// <summary>
        /// 消息转发配置TPS
        /// </summary>
        [JsonProperty("ForwardTPS")]
        public long? ForwardTPS{ get; set; }

        /// <summary>
        /// 消息转发当前TPS
        /// </summary>
        [JsonProperty("ForwardCurrentTPS")]
        public long? ForwardCurrentTPS{ get; set; }

        /// <summary>
        /// 实例单元数
        /// </summary>
        [JsonProperty("CellNum")]
        public long? CellNum{ get; set; }

        /// <summary>
        /// 实例Tag，企业实例必传
        /// </summary>
        [JsonProperty("BillingTag")]
        public string BillingTag{ get; set; }

        /// <summary>
        /// 每日消息数
        /// </summary>
        [JsonProperty("EverydayFreeMessageCount")]
        public long? EverydayFreeMessageCount{ get; set; }

        /// <summary>
        /// 最大在线设备数
        /// </summary>
        [JsonProperty("MaxDeviceOnlineCount")]
        public long? MaxDeviceOnlineCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "TotalDeviceNum", this.TotalDeviceNum);
            this.SetParamSimple(map, prefix + "UsedDeviceNum", this.UsedDeviceNum);
            this.SetParamSimple(map, prefix + "ProjectNum", this.ProjectNum);
            this.SetParamSimple(map, prefix + "ProductNum", this.ProductNum);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "TotalDevice", this.TotalDevice);
            this.SetParamSimple(map, prefix + "ActivateDevice", this.ActivateDevice);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "UpDownTPS", this.UpDownTPS);
            this.SetParamSimple(map, prefix + "UpDownCurrentTPS", this.UpDownCurrentTPS);
            this.SetParamSimple(map, prefix + "ForwardTPS", this.ForwardTPS);
            this.SetParamSimple(map, prefix + "ForwardCurrentTPS", this.ForwardCurrentTPS);
            this.SetParamSimple(map, prefix + "CellNum", this.CellNum);
            this.SetParamSimple(map, prefix + "BillingTag", this.BillingTag);
            this.SetParamSimple(map, prefix + "EverydayFreeMessageCount", this.EverydayFreeMessageCount);
            this.SetParamSimple(map, prefix + "MaxDeviceOnlineCount", this.MaxDeviceOnlineCount);
        }
    }
}

