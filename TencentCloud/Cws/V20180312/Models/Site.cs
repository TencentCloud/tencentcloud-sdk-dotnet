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

namespace TencentCloud.Cws.V20180312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Site : AbstractModel
    {
        
        /// <summary>
        /// 站点ID。
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 监控任务ID，为0时表示未加入监控任务。
        /// </summary>
        [JsonProperty("MonitorId")]
        public ulong? MonitorId{ get; set; }

        /// <summary>
        /// 站点url。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 站点名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 验证状态：0-未验证；1-已验证；2-验证失效，待重新验证。
        /// </summary>
        [JsonProperty("VerifyStatus")]
        public ulong? VerifyStatus{ get; set; }

        /// <summary>
        /// 监测状态：0-未监测；1-监测中；2-暂停监测。
        /// </summary>
        [JsonProperty("MonitorStatus")]
        public ulong? MonitorStatus{ get; set; }

        /// <summary>
        /// 扫描状态：0-待扫描（无任何扫描结果）；1-扫描中（正在进行扫描）；2-已扫描（有扫描结果且不正在扫描）；3-扫描完成待同步结果。
        /// </summary>
        [JsonProperty("ScanStatus")]
        public ulong? ScanStatus{ get; set; }

        /// <summary>
        /// 最近一次的AIScanner的扫描任务id，注意取消的情况。
        /// </summary>
        [JsonProperty("LastScanTaskId")]
        public ulong? LastScanTaskId{ get; set; }

        /// <summary>
        /// 最近一次扫描开始时间。
        /// </summary>
        [JsonProperty("LastScanStartTime")]
        public string LastScanStartTime{ get; set; }

        /// <summary>
        /// 最近一次扫描完成时间。
        /// </summary>
        [JsonProperty("LastScanFinishTime")]
        public string LastScanFinishTime{ get; set; }

        /// <summary>
        /// 最近一次取消时间，取消即使用上一次扫描结果。
        /// </summary>
        [JsonProperty("LastScanCancelTime")]
        public string LastScanCancelTime{ get; set; }

        /// <summary>
        /// 最近一次扫描扫描的页面数。
        /// </summary>
        [JsonProperty("LastScanPageCount")]
        public ulong? LastScanPageCount{ get; set; }

        /// <summary>
        /// normal-正常扫描；deep-深度扫描。
        /// </summary>
        [JsonProperty("LastScanScannerType")]
        public string LastScanScannerType{ get; set; }

        /// <summary>
        /// 最近一次扫描高风险漏洞数量。
        /// </summary>
        [JsonProperty("LastScanVulsHighNum")]
        public ulong? LastScanVulsHighNum{ get; set; }

        /// <summary>
        /// 最近一次扫描中风险漏洞数量。
        /// </summary>
        [JsonProperty("LastScanVulsMiddleNum")]
        public ulong? LastScanVulsMiddleNum{ get; set; }

        /// <summary>
        /// 最近一次扫描低风险漏洞数量。
        /// </summary>
        [JsonProperty("LastScanVulsLowNum")]
        public ulong? LastScanVulsLowNum{ get; set; }

        /// <summary>
        /// 最近一次扫描提示信息数量。
        /// </summary>
        [JsonProperty("LastScanVulsNoticeNum")]
        public ulong? LastScanVulsNoticeNum{ get; set; }

        /// <summary>
        /// 记录添加时间。
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// 记录最近修改时间。
        /// </summary>
        [JsonProperty("UpdatedAt")]
        public string UpdatedAt{ get; set; }

        /// <summary>
        /// 速率限制，每秒发送X个HTTP请求。
        /// </summary>
        [JsonProperty("LastScanRateLimit")]
        public ulong? LastScanRateLimit{ get; set; }

        /// <summary>
        /// 最近一次扫描漏洞总数量。
        /// </summary>
        [JsonProperty("LastScanVulsNum")]
        public ulong? LastScanVulsNum{ get; set; }

        /// <summary>
        /// 最近一次扫描提示总数量
        /// </summary>
        [JsonProperty("LastScanNoticeNum")]
        public ulong? LastScanNoticeNum{ get; set; }

        /// <summary>
        /// 扫描进度，百分比整数
        /// </summary>
        [JsonProperty("Progress")]
        public ulong? Progress{ get; set; }

        /// <summary>
        /// 云用户appid。
        /// </summary>
        [JsonProperty("Appid")]
        public ulong? Appid{ get; set; }

        /// <summary>
        /// 云用户标识。
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 网站是否需要登录扫描：0-未知；-1-不需要；1-需要。
        /// </summary>
        [JsonProperty("NeedLogin")]
        public long? NeedLogin{ get; set; }

        /// <summary>
        /// 登录后的cookie。
        /// </summary>
        [JsonProperty("LoginCookie")]
        public string LoginCookie{ get; set; }

        /// <summary>
        /// 登录后的cookie是否有效：0-无效；1-有效。
        /// </summary>
        [JsonProperty("LoginCookieValid")]
        public ulong? LoginCookieValid{ get; set; }

        /// <summary>
        /// 用于测试cookie是否有效的URL。
        /// </summary>
        [JsonProperty("LoginCheckUrl")]
        public string LoginCheckUrl{ get; set; }

        /// <summary>
        /// 用于测试cookie是否有效的关键字。
        /// </summary>
        [JsonProperty("LoginCheckKw")]
        public string LoginCheckKw{ get; set; }

        /// <summary>
        /// 禁止扫描器扫描的目录关键字。
        /// </summary>
        [JsonProperty("ScanDisallow")]
        public string ScanDisallow{ get; set; }

        /// <summary>
        /// 访问网站的客户端标识。
        /// </summary>
        [JsonProperty("UserAgent")]
        public string UserAgent{ get; set; }

        /// <summary>
        /// 内容检测状态：0-未检测；1-已检测；
        /// </summary>
        [JsonProperty("ContentStatus")]
        public ulong? ContentStatus{ get; set; }

        /// <summary>
        /// 最近一次扫描内容检测数量
        /// </summary>
        [JsonProperty("LastScanContentNum")]
        public ulong? LastScanContentNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "MonitorId", this.MonitorId);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "VerifyStatus", this.VerifyStatus);
            this.SetParamSimple(map, prefix + "MonitorStatus", this.MonitorStatus);
            this.SetParamSimple(map, prefix + "ScanStatus", this.ScanStatus);
            this.SetParamSimple(map, prefix + "LastScanTaskId", this.LastScanTaskId);
            this.SetParamSimple(map, prefix + "LastScanStartTime", this.LastScanStartTime);
            this.SetParamSimple(map, prefix + "LastScanFinishTime", this.LastScanFinishTime);
            this.SetParamSimple(map, prefix + "LastScanCancelTime", this.LastScanCancelTime);
            this.SetParamSimple(map, prefix + "LastScanPageCount", this.LastScanPageCount);
            this.SetParamSimple(map, prefix + "LastScanScannerType", this.LastScanScannerType);
            this.SetParamSimple(map, prefix + "LastScanVulsHighNum", this.LastScanVulsHighNum);
            this.SetParamSimple(map, prefix + "LastScanVulsMiddleNum", this.LastScanVulsMiddleNum);
            this.SetParamSimple(map, prefix + "LastScanVulsLowNum", this.LastScanVulsLowNum);
            this.SetParamSimple(map, prefix + "LastScanVulsNoticeNum", this.LastScanVulsNoticeNum);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "UpdatedAt", this.UpdatedAt);
            this.SetParamSimple(map, prefix + "LastScanRateLimit", this.LastScanRateLimit);
            this.SetParamSimple(map, prefix + "LastScanVulsNum", this.LastScanVulsNum);
            this.SetParamSimple(map, prefix + "LastScanNoticeNum", this.LastScanNoticeNum);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "Appid", this.Appid);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "NeedLogin", this.NeedLogin);
            this.SetParamSimple(map, prefix + "LoginCookie", this.LoginCookie);
            this.SetParamSimple(map, prefix + "LoginCookieValid", this.LoginCookieValid);
            this.SetParamSimple(map, prefix + "LoginCheckUrl", this.LoginCheckUrl);
            this.SetParamSimple(map, prefix + "LoginCheckKw", this.LoginCheckKw);
            this.SetParamSimple(map, prefix + "ScanDisallow", this.ScanDisallow);
            this.SetParamSimple(map, prefix + "UserAgent", this.UserAgent);
            this.SetParamSimple(map, prefix + "ContentStatus", this.ContentStatus);
            this.SetParamSimple(map, prefix + "LastScanContentNum", this.LastScanContentNum);
        }
    }
}

