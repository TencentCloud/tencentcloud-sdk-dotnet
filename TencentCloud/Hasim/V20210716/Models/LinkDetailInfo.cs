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

namespace TencentCloud.Hasim.V20210716.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LinkDetailInfo : AbstractModel
    {
        
        /// <summary>
        /// 云兔连接ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// 卡片状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 激活时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActiveTime")]
        public string ActiveTime{ get; set; }

        /// <summary>
        /// 过期时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 数据用量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataUse")]
        public float? DataUse{ get; set; }

        /// <summary>
        /// 语音用量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AudioUse")]
        public long? AudioUse{ get; set; }

        /// <summary>
        /// 短信用量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SmsUse")]
        public long? SmsUse{ get; set; }

        /// <summary>
        /// 在线状态 0 未激活 1 在线 2 离线
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LinkedState")]
        public long? LinkedState{ get; set; }

        /// <summary>
        /// 预期策略ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TacticID")]
        public long? TacticID{ get; set; }

        /// <summary>
        /// 策略下发状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TacticStatus")]
        public long? TacticStatus{ get; set; }

        /// <summary>
        /// 策略下发成功过期时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TacticExpireTime")]
        public string TacticExpireTime{ get; set; }

        /// <summary>
        /// 高级日志预期状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsActiveLog")]
        public bool? IsActiveLog{ get; set; }

        /// <summary>
        /// 运营商 1移动 2联通 3电信
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TeleOperator")]
        public long? TeleOperator{ get; set; }

        /// <summary>
        /// 设备最新上报信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Report")]
        public DeviceReport Report{ get; set; }

        /// <summary>
        /// 标签列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 运营商ICCID信息集合
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Cards")]
        public TeleOperatorCard[] Cards{ get; set; }

        /// <summary>
        /// 云兔实际卡片ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CardID")]
        public string CardID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ActiveTime", this.ActiveTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "DataUse", this.DataUse);
            this.SetParamSimple(map, prefix + "AudioUse", this.AudioUse);
            this.SetParamSimple(map, prefix + "SmsUse", this.SmsUse);
            this.SetParamSimple(map, prefix + "LinkedState", this.LinkedState);
            this.SetParamSimple(map, prefix + "TacticID", this.TacticID);
            this.SetParamSimple(map, prefix + "TacticStatus", this.TacticStatus);
            this.SetParamSimple(map, prefix + "TacticExpireTime", this.TacticExpireTime);
            this.SetParamSimple(map, prefix + "IsActiveLog", this.IsActiveLog);
            this.SetParamSimple(map, prefix + "TeleOperator", this.TeleOperator);
            this.SetParamObj(map, prefix + "Report.", this.Report);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamArrayObj(map, prefix + "Cards.", this.Cards);
            this.SetParamSimple(map, prefix + "CardID", this.CardID);
        }
    }
}

