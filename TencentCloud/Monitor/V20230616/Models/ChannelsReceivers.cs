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

namespace TencentCloud.Monitor.V20230616.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChannelsReceivers : AbstractModel
    {
        
        /// <summary>
        /// <p>通知渠道名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChannelName")]
        public string ChannelName{ get; set; }

        /// <summary>
        /// <p>接收者</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Receivers")]
        public string[] Receivers{ get; set; }

        /// <summary>
        /// <p>发送结果,0-无效,1-成功,2-失败,3-无需发送</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SendStatus")]
        public string SendStatus{ get; set; }

        /// <summary>
        /// <p>参数定义 渠道返回的原始状态码。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SendStatusCode")]
        public string SendStatusCode{ get; set; }

        /// <summary>
        /// <p>Ark 发起该渠道调用的时间</p><p>单位：Unix 秒级时间戳</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SendTime")]
        public long? SendTime{ get; set; }

        /// <summary>
        /// <p>该渠道本次实际发送的子渠道全名，格式为 父渠道_子渠道</p><p>枚举值：</p><ul><li>QCloudYehe_site： 腾讯云野鹤，站内信</li><li>QCloudYehe_email： 腾讯云野鹤，电子邮件</li><li>QCloudYehe_sms： 腾讯云野鹤，短信</li><li>QCloudYehe_wechat： 腾讯云野鹤，微信</li><li>QCloudYehe_voice： 腾讯云野鹤，语音</li><li>QCloudYehe_qywx： 腾讯云野鹤，企业微信</li><li>QCloudYehe_andon： 腾讯云野鹤，安灯</li><li>TOF_weWorkMessage： TOF，企业微信消息</li><li>TOF_email： TOF，企业邮箱</li><li>TOF_phoneCall： TOF，电话</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubChannels")]
        public string[] SubChannels{ get; set; }

        /// <summary>
        /// <p>该渠道本次执行情况的文字描述</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecDetail")]
        public string ExecDetail{ get; set; }

        /// <summary>
        /// <p>短信真实投递状态，来自野鹤 smsStatus 回调的 reportStatus 原值</p><p>枚举值：</p><ul><li>SUCCESS： 短信已真实送达</li><li>FAIL： 短信真实投递失败，失败原因见 RealDeliverErrMsg</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RealDeliverStatus")]
        public string RealDeliverStatus{ get; set; }

        /// <summary>
        /// <p>用户真实收到短信的时间，取野鹤回调 userReceiverTime 原文字符串</p><p>参数格式：YYYY-MM-DD HH:mm:ss</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RealDeliverTime")]
        public string RealDeliverTime{ get; set; }

        /// <summary>
        /// <p>短信真实投递回执中的结果码，取野鹤回调 errmsg 原值</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RealDeliverErrMsg")]
        public string RealDeliverErrMsg{ get; set; }

        /// <summary>
        /// <p>该渠道下各子渠道的消息正文明细</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Contents")]
        public ChannelContent[] Contents{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChannelName", this.ChannelName);
            this.SetParamArraySimple(map, prefix + "Receivers.", this.Receivers);
            this.SetParamSimple(map, prefix + "SendStatus", this.SendStatus);
            this.SetParamSimple(map, prefix + "SendStatusCode", this.SendStatusCode);
            this.SetParamSimple(map, prefix + "SendTime", this.SendTime);
            this.SetParamArraySimple(map, prefix + "SubChannels.", this.SubChannels);
            this.SetParamSimple(map, prefix + "ExecDetail", this.ExecDetail);
            this.SetParamSimple(map, prefix + "RealDeliverStatus", this.RealDeliverStatus);
            this.SetParamSimple(map, prefix + "RealDeliverTime", this.RealDeliverTime);
            this.SetParamSimple(map, prefix + "RealDeliverErrMsg", this.RealDeliverErrMsg);
            this.SetParamArrayObj(map, prefix + "Contents.", this.Contents);
        }
    }
}

