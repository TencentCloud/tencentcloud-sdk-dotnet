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

    public class CatLog : AbstractModel
    {
        
        /// <summary>
        /// 拨测时间点
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// 拨测类型
        /// </summary>
        [JsonProperty("CatTypeName")]
        public string CatTypeName{ get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("TaskId")]
        public ulong? TaskId{ get; set; }

        /// <summary>
        /// 拨测点所在城市
        /// </summary>
        [JsonProperty("City")]
        public string City{ get; set; }

        /// <summary>
        /// 拨测点所在运营商
        /// </summary>
        [JsonProperty("Isp")]
        public string Isp{ get; set; }

        /// <summary>
        /// 被拨测Server的IP
        /// </summary>
        [JsonProperty("ServerIp")]
        public string ServerIp{ get; set; }

        /// <summary>
        /// 被拨测Server的域名
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// 执行耗时，单位毫秒
        /// </summary>
        [JsonProperty("TotalTime")]
        public ulong? TotalTime{ get; set; }

        /// <summary>
        /// 成功失败(1 失败，0 成功）
        /// </summary>
        [JsonProperty("ResultType")]
        public ulong? ResultType{ get; set; }

        /// <summary>
        /// 失败错误码
        /// </summary>
        [JsonProperty("ResultCode")]
        public ulong? ResultCode{ get; set; }

        /// <summary>
        /// 请求包大小
        /// </summary>
        [JsonProperty("ReqPkgSize")]
        public ulong? ReqPkgSize{ get; set; }

        /// <summary>
        /// 回应包大小
        /// </summary>
        [JsonProperty("RspPkgSize")]
        public ulong? RspPkgSize{ get; set; }

        /// <summary>
        /// 拨测请求
        /// </summary>
        [JsonProperty("ReqMsg")]
        public string ReqMsg{ get; set; }

        /// <summary>
        /// 拨测回应
        /// </summary>
        [JsonProperty("RespMsg")]
        public string RespMsg{ get; set; }

        /// <summary>
        /// 客户端IP
        /// </summary>
        [JsonProperty("ClientIp")]
        public string ClientIp{ get; set; }

        /// <summary>
        /// 拨测点所在城市名称
        /// </summary>
        [JsonProperty("CityName")]
        public string CityName{ get; set; }

        /// <summary>
        /// 拨测点所在运营商名称
        /// </summary>
        [JsonProperty("IspName")]
        public string IspName{ get; set; }

        /// <summary>
        /// 解析耗时，单位毫秒
        /// </summary>
        [JsonProperty("ParseTime")]
        public ulong? ParseTime{ get; set; }

        /// <summary>
        /// 连接耗时，单位毫秒
        /// </summary>
        [JsonProperty("ConnectTime")]
        public ulong? ConnectTime{ get; set; }

        /// <summary>
        /// 数据发送耗时，单位毫秒
        /// </summary>
        [JsonProperty("SendTime")]
        public ulong? SendTime{ get; set; }

        /// <summary>
        /// 等待耗时，单位毫秒
        /// </summary>
        [JsonProperty("WaitTime")]
        public ulong? WaitTime{ get; set; }

        /// <summary>
        /// 接收耗时，单位毫秒
        /// </summary>
        [JsonProperty("ReceiveTime")]
        public ulong? ReceiveTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "CatTypeName", this.CatTypeName);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "Isp", this.Isp);
            this.SetParamSimple(map, prefix + "ServerIp", this.ServerIp);
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamSimple(map, prefix + "TotalTime", this.TotalTime);
            this.SetParamSimple(map, prefix + "ResultType", this.ResultType);
            this.SetParamSimple(map, prefix + "ResultCode", this.ResultCode);
            this.SetParamSimple(map, prefix + "ReqPkgSize", this.ReqPkgSize);
            this.SetParamSimple(map, prefix + "RspPkgSize", this.RspPkgSize);
            this.SetParamSimple(map, prefix + "ReqMsg", this.ReqMsg);
            this.SetParamSimple(map, prefix + "RespMsg", this.RespMsg);
            this.SetParamSimple(map, prefix + "ClientIp", this.ClientIp);
            this.SetParamSimple(map, prefix + "CityName", this.CityName);
            this.SetParamSimple(map, prefix + "IspName", this.IspName);
            this.SetParamSimple(map, prefix + "ParseTime", this.ParseTime);
            this.SetParamSimple(map, prefix + "ConnectTime", this.ConnectTime);
            this.SetParamSimple(map, prefix + "SendTime", this.SendTime);
            this.SetParamSimple(map, prefix + "WaitTime", this.WaitTime);
            this.SetParamSimple(map, prefix + "ReceiveTime", this.ReceiveTime);
        }
    }
}

