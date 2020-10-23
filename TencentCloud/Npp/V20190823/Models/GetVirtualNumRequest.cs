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

    public class GetVirtualNumRequest : AbstractModel
    {
        
        /// <summary>
        /// 业务appid
        /// </summary>
        [JsonProperty("BizAppId")]
        public string BizAppId{ get; set; }

        /// <summary>
        /// 被叫号码(号码前加 0086，如 008613631686024)
        /// </summary>
        [JsonProperty("Dst")]
        public string Dst{ get; set; }

        /// <summary>
        /// 主叫号码(号码前加 0086，如 008613631686024)，xb 模式下是不用填写，axb 模式下是必选
        /// </summary>
        [JsonProperty("Src")]
        public string Src{ get; set; }

        /// <summary>
        /// {“accreditList”:[“008613631686024”,”008612345678910”]}，主要用于 N-1 场景，号码绑定非共享是独占型，指定了 dst 独占中间号绑定，accreditList 表示这个列表成员可以拨打 dst 绑 定的中间号，默认值为空，表示所有号码都可以拨打独占型中间号绑定，最大集合不允许超过 30 个，仅适用于xb模式
        /// </summary>
        [JsonProperty("AccreditList")]
        public string[] AccreditList{ get; set; }

        /// <summary>
        /// 指定中间号（格式：008617013541251），如果该中间号已被使用则返回绑定失败。如果不带该字段则由腾讯侧从号码池里自动分配
        /// </summary>
        [JsonProperty("AssignVirtualNum")]
        public string AssignVirtualNum{ get; set; }

        /// <summary>
        /// 是否录音，0表示不录音，1表示录音。默认为不录音，注意如果需要录音回调，通话完成后需要等待一段时间，收到录音回调之后，再解绑中间号。
        /// </summary>
        [JsonProperty("Record")]
        public string Record{ get; set; }

        /// <summary>
        /// 主被叫显号号码归属地，指定该参数说明显号归属该城市，如果没有该城市号码会随机选取一个城市或者后台配置返回107，返回码详见 《腾讯-中间号-城市id.xlsx》
        /// </summary>
        [JsonProperty("CityId")]
        public string CityId{ get; set; }

        /// <summary>
        /// 应用二级业务 ID，bizId 需保证在该 appId 下全局唯一，最大长度不超过 16 个字节。
        /// </summary>
        [JsonProperty("BizId")]
        public string BizId{ get; set; }

        /// <summary>
        /// 号码最大绑定时间，不填默认为 24 小时，最长绑定时间是168小时，单位秒
        /// </summary>
        [JsonProperty("MaxAssignTime")]
        public string MaxAssignTime{ get; set; }

        /// <summary>
        /// 主叫发起呼叫状态：1
        /// 被叫发起呼叫状态：256
        /// 主叫响铃状态：2
        /// 被叫响铃状态：512
        /// 主叫接听状态：4
        /// 被叫接听状态：1024
        /// 主叫拒绝接听状态：8
        /// 被叫拒绝接听状态：2048
        /// 主叫正常挂机状态：16
        /// 被叫正常挂机状态：4096
        /// 主叫呼叫异常：32
        /// 被叫呼叫异常：8192
        /// 
        /// 例如：
        /// 值为 0：表示所有状态不需要推送
        /// 值为 4：表示只要推送主叫接听状态
        /// 值为 16191：表示所有状态都需要推送（上面所有值和）
        /// </summary>
        [JsonProperty("StatusFlag")]
        public string StatusFlag{ get; set; }

        /// <summary>
        /// 请填写statusFlag并设置值，状态回调通知地址，正式环境可以配置默认推送地址
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
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BizAppId", this.BizAppId);
            this.SetParamSimple(map, prefix + "Dst", this.Dst);
            this.SetParamSimple(map, prefix + "Src", this.Src);
            this.SetParamArraySimple(map, prefix + "AccreditList.", this.AccreditList);
            this.SetParamSimple(map, prefix + "AssignVirtualNum", this.AssignVirtualNum);
            this.SetParamSimple(map, prefix + "Record", this.Record);
            this.SetParamSimple(map, prefix + "CityId", this.CityId);
            this.SetParamSimple(map, prefix + "BizId", this.BizId);
            this.SetParamSimple(map, prefix + "MaxAssignTime", this.MaxAssignTime);
            this.SetParamSimple(map, prefix + "StatusFlag", this.StatusFlag);
            this.SetParamSimple(map, prefix + "StatusUrl", this.StatusUrl);
            this.SetParamSimple(map, prefix + "HangupUrl", this.HangupUrl);
            this.SetParamSimple(map, prefix + "RecordUrl", this.RecordUrl);
        }
    }
}

