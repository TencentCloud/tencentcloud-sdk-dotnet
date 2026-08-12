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

namespace TencentCloud.Rce.V20260130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReportEventRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>事件码，标准事件包含：</p><p>枚举值：</p><ul><li>login： 登录</li><li>register： 注册</li><li>create_order： 创建订单</li><li>transaction： 交易支付</li><li>charge_back： 拒付</li><li>sms： 短信</li><li>logout： 登出</li><li>modify_account： 修改账号</li><li>modify_password： 修改密码</li><li>security_verification： 安全验证</li><li>add_promotion： 参加营销活动</li><li>redeem： 兑奖</li><li>withdraw： 提现</li><li>cust_event： 自定义事件，cust_xxx</li><li>scan_code： 扫码</li><li>lucky_draw： 抽奖</li><li>task： 做任务</li><li>invitation： 邀请</li><li>claim_red_packet： 领红包</li><li>browse： 浏览</li></ul><p>自定义事件可与RCE约定后进行风险评估</p>
        /// </summary>
        [JsonProperty("EventCode")]
        public string EventCode{ get; set; }

        /// <summary>
        /// <p>事件的发生时间</p><p>参数格式：符合ISO 8601标准的带UTC时区的毫秒级时间</p>
        /// </summary>
        [JsonProperty("EventTime")]
        public string EventTime{ get; set; }

        /// <summary>
        /// <p>用户当前会话 ID， 用于关联用户登录前后的动作，如果没有传UserId，则SessionId必传，如缺失则可填充空字符串</p>
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// <p>用户设备指纹token标识，在您的网站或者应用程序中集成设备指纹的SDK后获取</p>
        /// </summary>
        [JsonProperty("DeviceToken")]
        public string DeviceToken{ get; set; }

        /// <summary>
        /// <p>客户端 IP 地址（IPv4或IPv6）</p>
        /// </summary>
        [JsonProperty("UserIp")]
        public string UserIp{ get; set; }

        /// <summary>
        /// <p>事件详情，根据您输入的事件码传入对应的事件信息</p>
        /// </summary>
        [JsonProperty("EventDetail")]
        public EventDetail EventDetail{ get; set; }

        /// <summary>
        /// <p>用户在您系统中的唯一ID</p>
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// <p>用户邮箱</p>
        /// </summary>
        [JsonProperty("UserEmail")]
        public string UserEmail{ get; set; }

        /// <summary>
        /// <p>用户提供的联系方式</p><p>参数格式：符合E.164标准的带“+”、地区编码和号码的格式</p>
        /// </summary>
        [JsonProperty("UserPhone")]
        public string UserPhone{ get; set; }

        /// <summary>
        /// <p>web浏览器相关信息，若您已集成我们的设备指纹SDK，则无需传入此字段</p>
        /// </summary>
        [JsonProperty("Browser")]
        public Browser Browser{ get; set; }

        /// <summary>
        /// <p>应用程序、操作系统和移动设备详细信息，若您已集成我们的设备指纹SDK，则无需传入此字段</p>
        /// </summary>
        [JsonProperty("App")]
        public App App{ get; set; }

        /// <summary>
        /// <p>数据授权信息，国内地域必填</p>
        /// </summary>
        [JsonProperty("DataAuthorization")]
        public DataAuthorization DataAuthorization{ get; set; }

        /// <summary>
        /// <p>手机号码加密方式，国内地域必填</p><p>枚举值：</p><ul><li>md5： md5加密</li><li>plain： 明文</li></ul>
        /// </summary>
        [JsonProperty("UserPhoneEncrypt")]
        public string UserPhoneEncrypt{ get; set; }

        /// <summary>
        /// <p>微信开放账号</p>
        /// </summary>
        [JsonProperty("WeChatOpenId")]
        public string WeChatOpenId{ get; set; }

        /// <summary>
        /// <p>QQ开放账号</p>
        /// </summary>
        [JsonProperty("QQOpenId")]
        public string QQOpenId{ get; set; }

        /// <summary>
        /// <p>QQ应用ID，当传入QQ开放账号时，该字段必填，QQ分配给网站或应用的AppId，用来唯一标识网站或应用</p>
        /// </summary>
        [JsonProperty("QQAppId")]
        public string QQAppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EventCode", this.EventCode);
            this.SetParamSimple(map, prefix + "EventTime", this.EventTime);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "DeviceToken", this.DeviceToken);
            this.SetParamSimple(map, prefix + "UserIp", this.UserIp);
            this.SetParamObj(map, prefix + "EventDetail.", this.EventDetail);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "UserEmail", this.UserEmail);
            this.SetParamSimple(map, prefix + "UserPhone", this.UserPhone);
            this.SetParamObj(map, prefix + "Browser.", this.Browser);
            this.SetParamObj(map, prefix + "App.", this.App);
            this.SetParamObj(map, prefix + "DataAuthorization.", this.DataAuthorization);
            this.SetParamSimple(map, prefix + "UserPhoneEncrypt", this.UserPhoneEncrypt);
            this.SetParamSimple(map, prefix + "WeChatOpenId", this.WeChatOpenId);
            this.SetParamSimple(map, prefix + "QQOpenId", this.QQOpenId);
            this.SetParamSimple(map, prefix + "QQAppId", this.QQAppId);
        }
    }
}

