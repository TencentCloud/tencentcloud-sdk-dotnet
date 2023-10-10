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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AttackSourceEvent : AbstractModel
    {
        
        /// <summary>
        /// 事件类型：0：文件查杀，1：异常登录， 2：密码破解，3：恶意请求，4：高危命令
        /// </summary>
        [JsonProperty("EventType")]
        public ulong? EventType{ get; set; }

        /// <summary>
        /// 【文件查杀】病毒名 VirusName、文件名 FileName、文件路径 FilePath、文件大小 FileSize、文件MD5 MD5、首次发现时间 CreateTime、最近检测时间LatestScanTime、危害描述 HarmDescribe、修复建议SuggestScheme
        /// 【异常登录】来源IP SrcIp、来源地 Location、登录用户名 UserName、登录时间 LoginTime
        /// 【密码破解】来源IP SrcIp、来源地 City,Country 、协议 Protocol、登录用户名UserName 、端口 Port、尝试次数 Count、首次攻击时间 CreateTime、最近攻击时间 ModifyTime
        /// 【恶意请求】恶意请求域名 Url、进程ProcessName 、MD5 ProcessMd5、PID Pid、请求次数 AccessCount、最近请求时间 MergeTime、危害描述 HarmDescribe、修复建议SuggestScheme
        /// 【高危命令】命中规则名 RuleName、规则类别 RuleCategory、命令内容 BashCmd、数据来源 DetectBy、登录用户 User、PID Pid、发生时间 CreateTime 、危害描述 HarmDescribe、修复建议SuggestScheme
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 入侵时间
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 等级 事件统一等级 0：提示，1：低危,  2：中危,  3：高危,  4：严重
        /// </summary>
        [JsonProperty("Level")]
        public ulong? Level{ get; set; }

        /// <summary>
        /// 等级中文展示字符串
        /// </summary>
        [JsonProperty("LevelZh")]
        public string LevelZh{ get; set; }

        /// <summary>
        /// 事件id
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 主机uuid
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "LevelZh", this.LevelZh);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
        }
    }
}

