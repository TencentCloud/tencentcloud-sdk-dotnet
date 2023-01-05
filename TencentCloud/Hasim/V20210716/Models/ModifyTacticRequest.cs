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

namespace TencentCloud.Hasim.V20210716.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyTacticRequest : AbstractModel
    {
        
        /// <summary>
        /// 策略名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 是否自动执行
        /// </summary>
        [JsonProperty("IsAuto")]
        public long? IsAuto{ get; set; }

        /// <summary>
        /// 心跳上报间隔(s)
        /// </summary>
        [JsonProperty("PingInterval")]
        public long? PingInterval{ get; set; }

        /// <summary>
        /// 是否开启弱信号检测
        /// </summary>
        [JsonProperty("IsWeak")]
        public long? IsWeak{ get; set; }

        /// <summary>
        /// 弱信号阈值（-dbm）
        /// </summary>
        [JsonProperty("WeakThreshold")]
        public long? WeakThreshold{ get; set; }

        /// <summary>
        /// 是否开启时延切换
        /// </summary>
        [JsonProperty("IsDelay")]
        public long? IsDelay{ get; set; }

        /// <summary>
        /// 网络时延阈值（ms）
        /// </summary>
        [JsonProperty("DelayThreshold")]
        public long? DelayThreshold{ get; set; }

        /// <summary>
        /// 是否开启假信号检测
        /// </summary>
        [JsonProperty("IsFake")]
        public long? IsFake{ get; set; }

        /// <summary>
        /// 假信号检测间隔（s）
        /// </summary>
        [JsonProperty("FakeInterval")]
        public long? FakeInterval{ get; set; }

        /// <summary>
        /// 是否开启网络制式检测
        /// </summary>
        [JsonProperty("IsNet")]
        public long? IsNet{ get; set; }

        /// <summary>
        /// 网络回落制式 1 2G、 2 3G 、 3 2/3G
        /// </summary>
        [JsonProperty("Network")]
        public long? Network{ get; set; }

        /// <summary>
        /// 是否开启移动检测
        /// </summary>
        [JsonProperty("IsMove")]
        public long? IsMove{ get; set; }

        /// <summary>
        /// 策略ID
        /// </summary>
        [JsonProperty("TacticID")]
        public long? TacticID{ get; set; }

        /// <summary>
        /// 是否开启最优先运营商
        /// </summary>
        [JsonProperty("IsPriorityTele")]
        public long? IsPriorityTele{ get; set; }

        /// <summary>
        /// 最优先运营商 1 移动、 2 联通、 3 电信 4 上次在线运营商
        /// </summary>
        [JsonProperty("PriorityTele")]
        public long? PriorityTele{ get; set; }

        /// <summary>
        /// 是否开启最不优先运营商
        /// </summary>
        [JsonProperty("IsBottomTele")]
        public long? IsBottomTele{ get; set; }

        /// <summary>
        /// 最不优先运营商 1 移动、 2 联通、 3 电信
        /// </summary>
        [JsonProperty("BottomTele")]
        public long? BottomTele{ get; set; }

        /// <summary>
        /// 是否最优先信号选取策略
        /// </summary>
        [JsonProperty("IsBestSignal")]
        public long? IsBestSignal{ get; set; }

        /// <summary>
        /// 假信号检测IP字符串，用逗号分隔
        /// </summary>
        [JsonProperty("FakeIP")]
        public string FakeIP{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "IsAuto", this.IsAuto);
            this.SetParamSimple(map, prefix + "PingInterval", this.PingInterval);
            this.SetParamSimple(map, prefix + "IsWeak", this.IsWeak);
            this.SetParamSimple(map, prefix + "WeakThreshold", this.WeakThreshold);
            this.SetParamSimple(map, prefix + "IsDelay", this.IsDelay);
            this.SetParamSimple(map, prefix + "DelayThreshold", this.DelayThreshold);
            this.SetParamSimple(map, prefix + "IsFake", this.IsFake);
            this.SetParamSimple(map, prefix + "FakeInterval", this.FakeInterval);
            this.SetParamSimple(map, prefix + "IsNet", this.IsNet);
            this.SetParamSimple(map, prefix + "Network", this.Network);
            this.SetParamSimple(map, prefix + "IsMove", this.IsMove);
            this.SetParamSimple(map, prefix + "TacticID", this.TacticID);
            this.SetParamSimple(map, prefix + "IsPriorityTele", this.IsPriorityTele);
            this.SetParamSimple(map, prefix + "PriorityTele", this.PriorityTele);
            this.SetParamSimple(map, prefix + "IsBottomTele", this.IsBottomTele);
            this.SetParamSimple(map, prefix + "BottomTele", this.BottomTele);
            this.SetParamSimple(map, prefix + "IsBestSignal", this.IsBestSignal);
            this.SetParamSimple(map, prefix + "FakeIP", this.FakeIP);
        }
    }
}

