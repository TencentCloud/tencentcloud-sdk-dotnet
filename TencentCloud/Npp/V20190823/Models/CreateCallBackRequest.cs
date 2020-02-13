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

namespace TencentCloud.Npp.V20190823.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCallBackRequest : AbstractModel
    {
        
        /// <summary>
        /// 业务appid
        /// </summary>
        [JsonProperty("BizAppId")]
        public string BizAppId{ get; set; }

        /// <summary>
        /// 主叫号码(必须为 11 位手机号，号码前加 0086，如 008613631686024)
        /// </summary>
        [JsonProperty("Src")]
        public string Src{ get; set; }

        /// <summary>
        /// 被叫号码(必须为 11 位手机或固话号码,号码前加 0086，如008613631686024，固话如：0086075586013388)
        /// </summary>
        [JsonProperty("Dst")]
        public string Dst{ get; set; }

        /// <summary>
        /// 主叫显示系统分配的固话号码，如不填显示随机分配号码
        /// </summary>
        [JsonProperty("SrcDisplayNum")]
        public string SrcDisplayNum{ get; set; }

        /// <summary>
        /// 被叫显示系统分配的固话号码，如不填显示随机分配号码
        /// </summary>
        [JsonProperty("DstDisplayNum")]
        public string DstDisplayNum{ get; set; }

        /// <summary>
        /// 是否录音，0 表示不录音，1 表示录音。默认为不录音
        /// </summary>
        [JsonProperty("Record")]
        public string Record{ get; set; }

        /// <summary>
        /// 允许最大通话时间，不填默认为 30 分钟（单位：分钟）
        /// </summary>
        [JsonProperty("MaxAllowTime")]
        public string MaxAllowTime{ get; set; }

        /// <summary>
        /// 主叫发起呼叫状态：1 被叫发起呼叫状态：256 主叫响铃状态：2 被叫响铃状态：512 主叫接听状态：4 被叫接听状态：1024 主叫拒绝接听状态：8 被叫拒绝接听状态：2048 主叫正常挂机状态：16 被叫正常挂机状态：4096 主叫呼叫异常：32 被叫呼叫异常：8192
        /// 例如：当值为 0：表示所有状态不需要推送；当值为 4：表示只要推送主叫接听状态；当值为 16191：表示所有状态都需要推送(上面所有值和)
        /// </summary>
        [JsonProperty("StatusFlag")]
        public string StatusFlag{ get; set; }

        /// <summary>
        /// 状态回调通知地址，正式环境可以配置默认推送地址
        /// </summary>
        [JsonProperty("StatusUrl")]
        public string StatusUrl{ get; set; }

        /// <summary>
        /// 话单回调通知地址，正式环境可以配置默认推送地址
        /// </summary>
        [JsonProperty("HangupUrl")]
        public string HangupUrl{ get; set; }

        /// <summary>
        /// 录单 URL 回调通知地址，正式环境可以配置默认推送地址
        /// </summary>
        [JsonProperty("RecordUrl")]
        public string RecordUrl{ get; set; }

        /// <summary>
        /// 业务应用 key，业务用该 key 可以区分内部业务或客户产品等，该 key 需保证在该 appId 下全局唯一，最大长度不超过 64 个字节，bizId 只能包含数字、字母。
        /// </summary>
        [JsonProperty("BizId")]
        public string BizId{ get; set; }

        /// <summary>
        /// 最后一次呼叫 callId，带上该字段以后，平台会参考该 callId 分配线路，优先不分配该 callId 通话线路（注：谨慎使用，这个会影响线路调度）
        /// </summary>
        [JsonProperty("LastCallId")]
        public string LastCallId{ get; set; }

        /// <summary>
        /// 结构体，主叫呼叫预处理操作，根据不同操作确认是否呼通被叫。如需使用，本结构体需要与 keyList 结构体配合使用，此时这两个参数都为必填项
        /// </summary>
        [JsonProperty("PreCallerHandle")]
        public RreCallerHandle PreCallerHandle{ get; set; }

        /// <summary>
        /// 订单 ID，最大长度不超过64个字节，对于一些有订单状态 App 相关应用使用（如达人帮接入 App 应用)，该字段只在帐单中带上，其它回调不附带该字段
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BizAppId", this.BizAppId);
            this.SetParamSimple(map, prefix + "Src", this.Src);
            this.SetParamSimple(map, prefix + "Dst", this.Dst);
            this.SetParamSimple(map, prefix + "SrcDisplayNum", this.SrcDisplayNum);
            this.SetParamSimple(map, prefix + "DstDisplayNum", this.DstDisplayNum);
            this.SetParamSimple(map, prefix + "Record", this.Record);
            this.SetParamSimple(map, prefix + "MaxAllowTime", this.MaxAllowTime);
            this.SetParamSimple(map, prefix + "StatusFlag", this.StatusFlag);
            this.SetParamSimple(map, prefix + "StatusUrl", this.StatusUrl);
            this.SetParamSimple(map, prefix + "HangupUrl", this.HangupUrl);
            this.SetParamSimple(map, prefix + "RecordUrl", this.RecordUrl);
            this.SetParamSimple(map, prefix + "BizId", this.BizId);
            this.SetParamSimple(map, prefix + "LastCallId", this.LastCallId);
            this.SetParamObj(map, prefix + "PreCallerHandle.", this.PreCallerHandle);
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
        }
    }
}

