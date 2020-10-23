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

namespace TencentCloud.Cat.V20180409.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CatTaskDetail : AbstractModel
    {
        
        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("TaskId")]
        public ulong? TaskId{ get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 任务周期，单位为分钟。目前支持1，5，15，30几种取值
        /// </summary>
        [JsonProperty("Period")]
        public ulong? Period{ get; set; }

        /// <summary>
        /// 拨测类型。http, https, ping, tcp 之一
        /// </summary>
        [JsonProperty("CatTypeName")]
        public string CatTypeName{ get; set; }

        /// <summary>
        /// 拨测任务的URL
        /// </summary>
        [JsonProperty("CgiUrl")]
        public string CgiUrl{ get; set; }

        /// <summary>
        /// 拨测分组ID
        /// </summary>
        [JsonProperty("AgentGroupId")]
        public ulong? AgentGroupId{ get; set; }

        /// <summary>
        /// 告警策略组ID
        /// </summary>
        [JsonProperty("PolicyGroupId")]
        public ulong? PolicyGroupId{ get; set; }

        /// <summary>
        /// 任务状态。1表示暂停，2表示运行中，0为初始态
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 任务创建时间
        /// </summary>
        [JsonProperty("AddTime")]
        public string AddTime{ get; set; }

        /// <summary>
        /// 任务类型。0 站点监控，2 可用性监控
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// 绑定的统一告警主题ID
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// 告警状态。0 未启用，1, 启用
        /// </summary>
        [JsonProperty("AlarmStatus")]
        public ulong? AlarmStatus{ get; set; }

        /// <summary>
        /// 指定的域名
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }

        /// <summary>
        /// 拨测目标的端口号
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// 要在结果中进行匹配的字符串
        /// </summary>
        [JsonProperty("CheckStr")]
        public string CheckStr{ get; set; }

        /// <summary>
        /// 1 表示通过检查结果是否包含CheckStr 进行校验
        /// </summary>
        [JsonProperty("CheckType")]
        public ulong? CheckType{ get; set; }

        /// <summary>
        /// 用户Agent信息
        /// </summary>
        [JsonProperty("UserAgent")]
        public string UserAgent{ get; set; }

        /// <summary>
        /// 设置的Cookie信息
        /// </summary>
        [JsonProperty("Cookie")]
        public string Cookie{ get; set; }

        /// <summary>
        /// POST 请求数据。空字符串表示非POST请求
        /// </summary>
        [JsonProperty("PostData")]
        public string PostData{ get; set; }

        /// <summary>
        /// SSL协议版本
        /// </summary>
        [JsonProperty("SslVer")]
        public string SslVer{ get; set; }

        /// <summary>
        /// 是否为Header请求。非0 Header 请求
        /// </summary>
        [JsonProperty("IsHeader")]
        public ulong? IsHeader{ get; set; }

        /// <summary>
        /// 目的DNS服务器
        /// </summary>
        [JsonProperty("DnsSvr")]
        public string DnsSvr{ get; set; }

        /// <summary>
        /// 需要检验是否在DNS IP列表的IP
        /// </summary>
        [JsonProperty("DnsCheckIp")]
        public string DnsCheckIp{ get; set; }

        /// <summary>
        /// DNS查询类型
        /// </summary>
        [JsonProperty("DnsQueryType")]
        public string DnsQueryType{ get; set; }

        /// <summary>
        /// 登录服务器的账号
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 登录服务器的密码
        /// </summary>
        [JsonProperty("PassWord")]
        public string PassWord{ get; set; }

        /// <summary>
        /// 是否使用安全链接SSL， 0 不使用，1 使用
        /// </summary>
        [JsonProperty("UseSecConn")]
        public ulong? UseSecConn{ get; set; }

        /// <summary>
        /// FTP登录验证方式  0 不验证  1 匿名登录  2 需要身份验证
        /// </summary>
        [JsonProperty("NeedAuth")]
        public ulong? NeedAuth{ get; set; }

        /// <summary>
        /// 请求数据类型。0 表示请求为字符串类型。1表示为二进制类型
        /// </summary>
        [JsonProperty("ReqDataType")]
        public ulong? ReqDataType{ get; set; }

        /// <summary>
        /// 发起TCP, UDP请求的协议请求数据
        /// </summary>
        [JsonProperty("ReqData")]
        public string ReqData{ get; set; }

        /// <summary>
        /// 响应数据类型。0 表示响应为字符串类型。1表示为二进制类型
        /// </summary>
        [JsonProperty("RespDataType")]
        public ulong? RespDataType{ get; set; }

        /// <summary>
        /// 预期的UDP请求的回应数据
        /// </summary>
        [JsonProperty("RespData")]
        public string RespData{ get; set; }

        /// <summary>
        /// 跟随跳转次数
        /// </summary>
        [JsonProperty("RedirectFollowNum")]
        public ulong? RedirectFollowNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "CatTypeName", this.CatTypeName);
            this.SetParamSimple(map, prefix + "CgiUrl", this.CgiUrl);
            this.SetParamSimple(map, prefix + "AgentGroupId", this.AgentGroupId);
            this.SetParamSimple(map, prefix + "PolicyGroupId", this.PolicyGroupId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "AddTime", this.AddTime);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "AlarmStatus", this.AlarmStatus);
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "CheckStr", this.CheckStr);
            this.SetParamSimple(map, prefix + "CheckType", this.CheckType);
            this.SetParamSimple(map, prefix + "UserAgent", this.UserAgent);
            this.SetParamSimple(map, prefix + "Cookie", this.Cookie);
            this.SetParamSimple(map, prefix + "PostData", this.PostData);
            this.SetParamSimple(map, prefix + "SslVer", this.SslVer);
            this.SetParamSimple(map, prefix + "IsHeader", this.IsHeader);
            this.SetParamSimple(map, prefix + "DnsSvr", this.DnsSvr);
            this.SetParamSimple(map, prefix + "DnsCheckIp", this.DnsCheckIp);
            this.SetParamSimple(map, prefix + "DnsQueryType", this.DnsQueryType);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "PassWord", this.PassWord);
            this.SetParamSimple(map, prefix + "UseSecConn", this.UseSecConn);
            this.SetParamSimple(map, prefix + "NeedAuth", this.NeedAuth);
            this.SetParamSimple(map, prefix + "ReqDataType", this.ReqDataType);
            this.SetParamSimple(map, prefix + "ReqData", this.ReqData);
            this.SetParamSimple(map, prefix + "RespDataType", this.RespDataType);
            this.SetParamSimple(map, prefix + "RespData", this.RespData);
            this.SetParamSimple(map, prefix + "RedirectFollowNum", this.RedirectFollowNum);
        }
    }
}

