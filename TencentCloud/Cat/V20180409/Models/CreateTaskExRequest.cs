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

    public class CreateTaskExRequest : AbstractModel
    {
        
        /// <summary>
        /// http, https, ping, tcp, ftp, smtp, udp, dns 之一
        /// </summary>
        [JsonProperty("CatTypeName")]
        public string CatTypeName{ get; set; }

        /// <summary>
        /// 拨测的URL， 例如：www.qq.com (URL域名解析需要能解析出具体的IP)
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 拨测周期。取值可为1,5,15,30之一, 单位：分钟。精度不能低于用户等级规定的最小精度
        /// </summary>
        [JsonProperty("Period")]
        public ulong? Period{ get; set; }

        /// <summary>
        /// 拨测任务名称不能超过32个字符。同一个用户创建的任务名不可重复
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 拨测分组ID，体现本拨测任务要采用哪些运营商作为拨测源。一般可直接填写本用户的默认拨测分组。参见：DescribeAgentGroups 接口，本参数使用返回结果里的GroupId的值。注意： Type为0时，AgentGroupId为必填
        /// </summary>
        [JsonProperty("AgentGroupId")]
        public ulong? AgentGroupId{ get; set; }

        /// <summary>
        /// 指定域名(如需要)
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }

        /// <summary>
        /// 是否为Header请求（非0 发起Header 请求。为0，且PostData 非空，发起POST请求。为0，PostData 为空，发起GET请求）
        /// </summary>
        [JsonProperty("IsHeader")]
        public ulong? IsHeader{ get; set; }

        /// <summary>
        /// URL中含有"https"时有用。缺省为SSLv23。需要为 TLSv1_2, TLSv1_1, TLSv1, SSLv2, SSLv23, SSLv3 之一
        /// </summary>
        [JsonProperty("SslVer")]
        public string SslVer{ get; set; }

        /// <summary>
        /// POST请求数据。空字符串表示非POST请求
        /// </summary>
        [JsonProperty("PostData")]
        public string PostData{ get; set; }

        /// <summary>
        /// 用户Agent信息
        /// </summary>
        [JsonProperty("UserAgent")]
        public string UserAgent{ get; set; }

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
        /// 需要设置的Cookie信息
        /// </summary>
        [JsonProperty("Cookie")]
        public string Cookie{ get; set; }

        /// <summary>
        /// 任务ID，用于验证且修改任务时传入原任务ID
        /// </summary>
        [JsonProperty("TaskId")]
        public ulong? TaskId{ get; set; }

        /// <summary>
        /// 登录服务器的账号。如果为空字符串，表示不用校验用户密码。只做简单连接服务器的拨测
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 登录服务器的密码
        /// </summary>
        [JsonProperty("PassWord")]
        public string PassWord{ get; set; }

        /// <summary>
        /// 缺省为0。0 表示请求为字符串类型。1表示为二进制类型
        /// </summary>
        [JsonProperty("ReqDataType")]
        public ulong? ReqDataType{ get; set; }

        /// <summary>
        /// 发起TCP, UDP请求的协议请求数据
        /// </summary>
        [JsonProperty("ReqData")]
        public string ReqData{ get; set; }

        /// <summary>
        /// 缺省为0。0 表示响应为字符串类型。1表示为二进制类型
        /// </summary>
        [JsonProperty("RespDataType")]
        public ulong? RespDataType{ get; set; }

        /// <summary>
        /// 预期的UDP请求的回应数据。字符串型，只需要返回的结果里包含本字符串算校验通过。二进制型，则需要严格等于才算通过
        /// </summary>
        [JsonProperty("RespData")]
        public string RespData{ get; set; }

        /// <summary>
        /// 目的DNS服务器  可以为空字符串
        /// </summary>
        [JsonProperty("DnsSvr")]
        public string DnsSvr{ get; set; }

        /// <summary>
        /// 需要检验是否在DNS IP列表的IP。可以为空字符串，表示不校验
        /// </summary>
        [JsonProperty("DnsCheckIp")]
        public string DnsCheckIp{ get; set; }

        /// <summary>
        /// 需要为下列值之一。缺省为A。A, MX, NS, CNAME, TXT, ANY
        /// </summary>
        [JsonProperty("DnsQueryType")]
        public string DnsQueryType{ get; set; }

        /// <summary>
        /// 是否使用安全链接SSL， 0 不使用，1 使用
        /// </summary>
        [JsonProperty("UseSecConn")]
        public ulong? UseSecConn{ get; set; }

        /// <summary>
        /// FTP登录验证方式， 0 不验证 ， 1 匿名登录， 2 需要身份验证
        /// </summary>
        [JsonProperty("NeedAuth")]
        public ulong? NeedAuth{ get; set; }

        /// <summary>
        /// 拨测目标的端口号
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// Type=0 默认 （站点监控）Type=2 可用率监控
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// IsVerify=0 非验证任务 IsVerify=1 验证任务，不传则默认为0
        /// </summary>
        [JsonProperty("IsVerify")]
        public ulong? IsVerify{ get; set; }

        /// <summary>
        /// 跟随跳转次数，取值范围0-5，不传则表示不跟随
        /// </summary>
        [JsonProperty("RedirectFollowNum")]
        public ulong? RedirectFollowNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CatTypeName", this.CatTypeName);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "AgentGroupId", this.AgentGroupId);
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "IsHeader", this.IsHeader);
            this.SetParamSimple(map, prefix + "SslVer", this.SslVer);
            this.SetParamSimple(map, prefix + "PostData", this.PostData);
            this.SetParamSimple(map, prefix + "UserAgent", this.UserAgent);
            this.SetParamSimple(map, prefix + "CheckStr", this.CheckStr);
            this.SetParamSimple(map, prefix + "CheckType", this.CheckType);
            this.SetParamSimple(map, prefix + "Cookie", this.Cookie);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "PassWord", this.PassWord);
            this.SetParamSimple(map, prefix + "ReqDataType", this.ReqDataType);
            this.SetParamSimple(map, prefix + "ReqData", this.ReqData);
            this.SetParamSimple(map, prefix + "RespDataType", this.RespDataType);
            this.SetParamSimple(map, prefix + "RespData", this.RespData);
            this.SetParamSimple(map, prefix + "DnsSvr", this.DnsSvr);
            this.SetParamSimple(map, prefix + "DnsCheckIp", this.DnsCheckIp);
            this.SetParamSimple(map, prefix + "DnsQueryType", this.DnsQueryType);
            this.SetParamSimple(map, prefix + "UseSecConn", this.UseSecConn);
            this.SetParamSimple(map, prefix + "NeedAuth", this.NeedAuth);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "IsVerify", this.IsVerify);
            this.SetParamSimple(map, prefix + "RedirectFollowNum", this.RedirectFollowNum);
        }
    }
}

