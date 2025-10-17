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

namespace TencentCloud.Ioa.V20220601.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDLPFileDetectTaskResult : AbstractModel
    {
        
        /// <summary>
        /// 提交任务时的文件md5
        /// </summary>
        [JsonProperty("FileMd5")]
        public string FileMd5{ get; set; }

        /// <summary>
        /// 提交任务时的文件名
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// 检测执行状态：0未执行 1等待执行 2执行中 3执行失败 4执行完成 
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        ///     FileAbstract:文件摘要
        ///     FileAttr:文件属性
        ///     FileCategory:命中分级分类 array
        ///     FileContent:命中信息json(array)
        /// 	            RuleId:规则Id
        /// 				RuleName:规则名称
        /// 				RuleLevel:规则等级
        /// 				Hits：命中词库内容
        /// 				    LibraryId：词库Id
        /// 					LibraryType:词库类型
        /// 					LibraryName:词库名称
        /// 					Attribute: 命中属性 doc.Content文件内容|doc.FileSize文件大小|doc.Name文件名|doc.Type文件类型
        /// 					String  待匹配内容
        /// 					Content 命中内容
        ///                 HitsTotal 规则命中次数
        ///     FileMd5 文件ND5
        ///     FileName 文件名
        ///     FileSize 文件大小
        ///     FileType 文件后缀
        ///     FileTypeName 文件类型名称
        ///     FinalDataLevel 命中最高等级
        ///     NodeId 节点唯一Id
        ///     NodeIp 节点IP
        ///     NodeName 节点名称
        ///     OperateTime 文件操作时间
        ///     Url 文件下载Url
        /// </summary>
        [JsonProperty("DetectResult")]
        public string DetectResult{ get; set; }

        /// <summary>
        /// 检测执行状态描述
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileMd5", this.FileMd5);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "DetectResult", this.DetectResult);
            this.SetParamSimple(map, prefix + "Message", this.Message);
        }
    }
}

