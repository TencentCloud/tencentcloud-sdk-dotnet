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

namespace TencentCloud.Rce.V20201103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OutputManageMarketingRiskValue : AbstractModel
    {
        
        /// <summary>
        /// 账号ID：对应输入参数。
        /// 当AccountType为1时，对应QQ的OpenId；
        /// 当AccountType为2时，对应微信的OpenId/UnionId；
        /// 当AccountType为10004时，对应手机号的MD5值；
        /// 当AccountType为10005时，对应手机号的SHA256值。
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 操作时间戳，单位秒（对应输入参数）。
        /// </summary>
        [JsonProperty("PostTime")]
        public ulong? PostTime{ get; set; }

        /// <summary>
        /// 业务参数。
        /// </summary>
        [JsonProperty("AssociateAccount")]
        public string AssociateAccount{ get; set; }

        /// <summary>
        /// 操作来源的外网IP（对应输入参数）。
        /// </summary>
        [JsonProperty("UserIp")]
        public string UserIp{ get; set; }

        /// <summary>
        /// 风险等级
        /// pass：无恶意
        /// review：低风险，需要人工审核
        /// reject：高风险，建议拦截
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// 风险类型，可能同时命中多个风险类型
        /// 1: 账号信用低，账号近期存在因恶意被处罚历史，网络低活跃，被举报等因素。
        /// 11: 疑似低活跃账号，账号活跃度与正常用户有差异。
        /// 2: 垃圾账号，疑似批量注册小号，近期存在严重违规或大量举报。
        /// 21: 疑似小号，账号有疑似线上养号，小号等行为。
        /// 22: 疑似违规账号，账号曾有违规行为、曾被举报过、曾因违规被处罚过等。
        /// 3: 无效账号，送检账号参数无法成功解析，请检查微信 OpenId 是否有误/AppId 与 QQ OpenId 无法关联/微信 OpenId 权限是否开通/手机号是否为中国大陆手机号；
        /// 4: 黑名单，该账号在业务侧有过拉黑记录。
        /// 5: 白名单，业务自行有添加过白名单记录。
        /// 101: 批量操作，存在 IP/设备/环境等因素的聚集性异常。
        /// 1011: 疑似 IP 属性聚集，出现 IP 聚集。
        /// 1012: 疑似设备属性聚集，出现设备聚集。
        /// 102: 自动机，疑似自动机批量请求。
        /// 103: 恶意行为-网赚，疑似网赚。
        /// 104: 微信登录态无效，检查 WeChatAccessToken 参数，是否已经失效。
        /// 201: 环境风险，环境异常操作 IP/设备/环境存在异常。当前 IP 为非常用 IP 或恶意 IP 段。
        /// 2011: 疑似非常用IP，请求当前请求 IP 非该账号常用 IP。
        /// 2012: 疑似 IP 异常，使用 IDC 机房 IP 或使用代理 IP 或使用恶意 IP 等。
        /// 205: 非公网有效 IP，传进来的 IP 地址为内网 IP 地址或者 IP 保留地址。
        /// </summary>
        [JsonProperty("RiskType")]
        public long?[] RiskType{ get; set; }

        /// <summary>
        /// 设备指纹ID，如果集成了设备指纹，并传入了正确的DeviceToken和Platform，该字段正常输出；如果DeviceToken异常（校验不通过），则会在RiskType中返回"-1"标签，ConstId字段为空；如果没有集成设备指纹ConstId字段默认为空。
        /// </summary>
        [JsonProperty("ConstId")]
        public string ConstId{ get; set; }

        /// <summary>
        /// 风险扩展数据。
        /// </summary>
        [JsonProperty("RiskInformation")]
        public string RiskInformation{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "PostTime", this.PostTime);
            this.SetParamSimple(map, prefix + "AssociateAccount", this.AssociateAccount);
            this.SetParamSimple(map, prefix + "UserIp", this.UserIp);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamArraySimple(map, prefix + "RiskType.", this.RiskType);
            this.SetParamSimple(map, prefix + "ConstId", this.ConstId);
            this.SetParamSimple(map, prefix + "RiskInformation", this.RiskInformation);
        }
    }
}

