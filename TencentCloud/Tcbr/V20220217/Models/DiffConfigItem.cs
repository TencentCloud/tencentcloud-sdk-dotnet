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

namespace TencentCloud.Tcbr.V20220217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DiffConfigItem : AbstractModel
    {
        
        /// <summary>
        /// 配置项 Key
        /// MinNum 最小副本数
        /// MaxNum 最大副本数
        /// PolicyDetails 扩缩容策略
        /// AccessTypes 访问类型
        /// TimerScale 定时扩缩容
        /// InternalAccess 内网访问
        /// OperationMode 运行模式 noScale | condScale | alwaysScale | custom ｜ manualScale
        /// SessionAffinity 会话亲和性 open | close
        /// CpuSpecs cpu 规格
        /// MemSpecs mem规格
        /// EnvParam 环境变量
        /// LogPath 日志采集路径
        /// Port 端口
        /// Dockerfile dockerfile 文件名
        /// BuildDir 目标目录
        /// Tag 服务标签
        /// LogType 日志类型 none | default | custom 
        /// LogSetId 日志集Id
        /// LogTopicId 日志主题ID
        /// LogParseType 日志解析类型 json ｜ line
        /// EntryPoint entrypoint 命令
        /// Cmd cmd命令
        /// VpcConf 网络信息
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// 字符串类型配置项值
        /// InternalAccess、OperationMode、SessionAffinity、EnvParam、LogPath、Dockerfile、BuildDir、Tag、LogType、LogSetId、LogTopicId、LogParseType
        /// </summary>
        [JsonProperty("Value")]
        public string Value{ get; set; }

        /// <summary>
        /// int 类型配置项值
        /// MinNum、MaxNum、Port
        /// </summary>
        [JsonProperty("IntValue")]
        public long? IntValue{ get; set; }

        /// <summary>
        /// bool 类型配置项值
        /// </summary>
        [JsonProperty("BoolValue")]
        public bool? BoolValue{ get; set; }

        /// <summary>
        /// 浮点型配置项值
        /// CpuSpecs、MemSpecs
        /// </summary>
        [JsonProperty("FloatValue")]
        public float? FloatValue{ get; set; }

        /// <summary>
        /// 字符串数组配置项值
        /// AccessTypes，EntryPoint，Cmd
        /// </summary>
        [JsonProperty("ArrayValue")]
        public string[] ArrayValue{ get; set; }

        /// <summary>
        /// 扩缩容策略配置项值
        /// </summary>
        [JsonProperty("PolicyDetails")]
        public HpaPolicy[] PolicyDetails{ get; set; }

        /// <summary>
        /// 定时扩缩容配置项值
        /// </summary>
        [JsonProperty("TimerScale")]
        public TimerScale[] TimerScale{ get; set; }

        /// <summary>
        /// 配置内网访问时网络信息
        /// </summary>
        [JsonProperty("VpcConf")]
        public VpcConf VpcConf{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "Value", this.Value);
            this.SetParamSimple(map, prefix + "IntValue", this.IntValue);
            this.SetParamSimple(map, prefix + "BoolValue", this.BoolValue);
            this.SetParamSimple(map, prefix + "FloatValue", this.FloatValue);
            this.SetParamArraySimple(map, prefix + "ArrayValue.", this.ArrayValue);
            this.SetParamArrayObj(map, prefix + "PolicyDetails.", this.PolicyDetails);
            this.SetParamArrayObj(map, prefix + "TimerScale.", this.TimerScale);
            this.SetParamObj(map, prefix + "VpcConf.", this.VpcConf);
        }
    }
}

