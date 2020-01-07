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

namespace TencentCloud.Gme.V20180711
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Gme.V20180711.Models;

   public class GmeClient : AbstractClient{

       private const string endpoint = "gme.tencentcloudapi.com";
       private const string version = "2018-07-11";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public GmeClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public GmeClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 本接口(CreateApp)用于创建一个GME应用。
        /// </summary>
        /// <param name="req"><see cref="CreateAppRequest"/></param>
        /// <returns><see cref="CreateAppResponse"/></returns>
        public async Task<CreateAppResponse> CreateApp(CreateAppRequest req)
        {
             JsonResponseModel<CreateAppResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateApp接口的同步版本，本接口(CreateApp)用于创建一个GME应用。
        /// </summary>
        /// <param name="req">参考<see cref="CreateAppRequest"/></param>
        /// <returns>参考<see cref="CreateAppResponse"/>实例</returns>
        public CreateAppResponse CreateAppSync(CreateAppRequest req)
        {
             JsonResponseModel<CreateAppResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeAppStatistics)用于获取某个GME应用的用量数据。包括实时语音，语音消息及转文本，语音分析等。最长查询周期为最近30天。
        /// </summary>
        /// <param name="req"><see cref="DescribeAppStatisticsRequest"/></param>
        /// <returns><see cref="DescribeAppStatisticsResponse"/></returns>
        public async Task<DescribeAppStatisticsResponse> DescribeAppStatistics(DescribeAppStatisticsRequest req)
        {
             JsonResponseModel<DescribeAppStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAppStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAppStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeAppStatistics接口的同步版本，本接口(DescribeAppStatistics)用于获取某个GME应用的用量数据。包括实时语音，语音消息及转文本，语音分析等。最长查询周期为最近30天。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAppStatisticsRequest"/></param>
        /// <returns>参考<see cref="DescribeAppStatisticsResponse"/>实例</returns>
        public DescribeAppStatisticsResponse DescribeAppStatisticsSync(DescribeAppStatisticsRequest req)
        {
             JsonResponseModel<DescribeAppStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAppStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAppStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据应用ID和文件ID查询识别结果
        /// </summary>
        /// <param name="req"><see cref="DescribeFilterResultRequest"/></param>
        /// <returns><see cref="DescribeFilterResultResponse"/></returns>
        public async Task<DescribeFilterResultResponse> DescribeFilterResult(DescribeFilterResultRequest req)
        {
             JsonResponseModel<DescribeFilterResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFilterResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFilterResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeFilterResult接口的同步版本，根据应用ID和文件ID查询识别结果
        /// </summary>
        /// <param name="req">参考<see cref="DescribeFilterResultRequest"/></param>
        /// <returns>参考<see cref="DescribeFilterResultResponse"/>实例</returns>
        public DescribeFilterResultResponse DescribeFilterResultSync(DescribeFilterResultRequest req)
        {
             JsonResponseModel<DescribeFilterResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFilterResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFilterResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据日期查询识别结果列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFilterResultListRequest"/></param>
        /// <returns><see cref="DescribeFilterResultListResponse"/></returns>
        public async Task<DescribeFilterResultListResponse> DescribeFilterResultList(DescribeFilterResultListRequest req)
        {
             JsonResponseModel<DescribeFilterResultListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFilterResultList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFilterResultListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeFilterResultList接口的同步版本，根据日期查询识别结果列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeFilterResultListRequest"/></param>
        /// <returns>参考<see cref="DescribeFilterResultListResponse"/>实例</returns>
        public DescribeFilterResultListResponse DescribeFilterResultListSync(DescribeFilterResultListRequest req)
        {
             JsonResponseModel<DescribeFilterResultListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFilterResultList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFilterResultListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeScanResultList)用于查询语音检测结果，查询任务列表最多支持100个。
        /// <p style="color:red">如果在提交语音检测任务时未设置 Callback 字段，则需要通过本接口获取检测结果</p>
        /// </summary>
        /// <param name="req"><see cref="DescribeScanResultListRequest"/></param>
        /// <returns><see cref="DescribeScanResultListResponse"/></returns>
        public async Task<DescribeScanResultListResponse> DescribeScanResultList(DescribeScanResultListRequest req)
        {
             JsonResponseModel<DescribeScanResultListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScanResultList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScanResultListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeScanResultList接口的同步版本，本接口(DescribeScanResultList)用于查询语音检测结果，查询任务列表最多支持100个。
        /// <p style="color:red">如果在提交语音检测任务时未设置 Callback 字段，则需要通过本接口获取检测结果</p>
        /// </summary>
        /// <param name="req">参考<see cref="DescribeScanResultListRequest"/></param>
        /// <returns>参考<see cref="DescribeScanResultListResponse"/>实例</returns>
        public DescribeScanResultListResponse DescribeScanResultListSync(DescribeScanResultListRequest req)
        {
             JsonResponseModel<DescribeScanResultListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScanResultList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScanResultListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ModifyAppStatus)用于修改应用总开关状态。
        /// </summary>
        /// <param name="req"><see cref="ModifyAppStatusRequest"/></param>
        /// <returns><see cref="ModifyAppStatusResponse"/></returns>
        public async Task<ModifyAppStatusResponse> ModifyAppStatus(ModifyAppStatusRequest req)
        {
             JsonResponseModel<ModifyAppStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAppStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAppStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyAppStatus接口的同步版本，本接口(ModifyAppStatus)用于修改应用总开关状态。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyAppStatusRequest"/></param>
        /// <returns>参考<see cref="ModifyAppStatusResponse"/>实例</returns>
        public ModifyAppStatusResponse ModifyAppStatusSync(ModifyAppStatusRequest req)
        {
             JsonResponseModel<ModifyAppStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAppStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAppStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ScanVoice)用于提交语音检测任务，检测任务列表最多支持100个。使用前请您登录[控制台 - 服务配置](https://console.cloud.tencent.com/gamegme/conf)开启语音分析服务。
        /// </br></br>
        /// 
        /// <h4><b>功能试用说明：</b></h4>
        /// <li>打开前往<a href="https://console.cloud.tencent.com/gamegme/tryout">控制台 - 产品试用</a>免费试用语音分析服务。</li>
        /// </br>
        /// 
        /// <h4><b>接口功能说明：</b></h4>
        /// <li>支持对语音流或语音文件进行检测，判断其中是否包含违规内容。</li>
        /// <li>支持设置回调地址 Callback 获取检测结果，同时支持通过接口(查询语音检测结果)主动轮询获取检测结果。</li>
        /// <li>支持场景输入，包括：谩骂、色情、涉政等场景</li>
        /// <li>支持批量提交检测任务。检测任务列表最多支持100个。</li>
        /// </br>
        /// <h4><b>音频文件限制说明：</b></h4>
        /// <li>音频文件大小限制：100 M</li>
        /// <li>音频文件时长限制：30分钟</li>
        /// <li>音频文件格式支持的类型：.wav、.m4a、.amr、.mp3、.aac、.wma、.ogg</li>
        /// </br>
        /// <h4><b>语音流限制说明：</b></h4>
        /// <li>语音流格式支持的类型：.m3u8、.flv</li>
        /// <li>语音流支持的传输协议：RTMP、HTTP、HTTPS</li>
        /// <li>语音流时长限制：4小时</li>
        /// <li>支持音视频流分离并对音频流进行分析</li>
        /// </br>
        /// <h4 id="Label_Value"><b>Scenes 与 Label 参数说明：</b></h4>
        /// <p>提交语音检测任务时，需要指定 Scenes 场景参数，<font color="red">目前要求您设置 Scenes 参数值为：["default"]</font>；而在检测结果中，则包含请求时指定的场景，以及对应类型的检测结果。</p>
        /// <table>
        /// <thread>
        /// <tr>
        /// <th>场景</th>
        /// <th>描述</th>
        /// <th>Label</th>
        /// </tr>
        /// </thread>
        /// <tbody>
        /// <tr>
        /// <td>语音检测</td>
        /// <td>语音检测的检测类型</td>
        /// <td>
        /// <p>normal:正常文本</p>
        /// <p>porn:色情</p>
        /// <p>politics:涉政</p>
        /// <p>abuse:谩骂</p>
        /// <p>ad :广告</p>
        /// <p>terrorism:暴恐</p>
        /// <p>contraband :违禁</p>
        /// <p>customized:自定义词库。目前白名单开放，如有需要请<a href="https://cloud.tencent.com/apply/p/8809fjcik56">联系我们</a>。</p>
        /// </td>
        /// </tr>
        /// </tbody>
        /// </table>
        /// </br>
        /// <h4 id="Callback_Declare"><b>回调相关说明：</b></h4>
        /// <li>如果在请求参数中指定了回调地址参数 Callback，即一个 HTTP(S) 协议接口的 URL，则需要支持 POST 方法，传输数据编码采用 UTF-8。</li>
        /// <li>在推送回调数据后，接收到的 HTTP 状态码为 200 时，表示推送成功。</li>
        /// <li>HTTP 头参数说明：</li>
        /// <table>
        /// <thread>
        /// <tr>
        /// <th>名称</th>
        /// <th>类型</th>
        /// <th>是否必需</th>
        /// <th>描述</th>
        /// </tr>
        /// </thread>
        /// <tbody>
        /// <tr>
        /// <td>Signatue</td>
        /// <td>string</td>
        /// <td>是</td>
        /// <td>签名，具体见<a href="#Callback_Signatue">签名生成说明</a></td>
        /// </tr>
        /// </tbody>
        /// </table>
        /// <ul  id="Callback_Signatue">
        /// 	<li>签名生成说明：</li>
        /// 	<ul>
        /// 		<li>使用 HMAC-SH1 算法, 最终结果做 BASE64 编码;</li>
        /// 		<li>签名原文串为 POST+body 的整个json内容(长度以 Content-Length 为准);</li>
        /// 		<li>签名key为应用的 SecretKey，可以通过控制台查看。</li>
        /// 	</ul>
        /// </ul>
        /// 
        /// <li>回调示例如下<font color="red">（详细字段说明见结构：
        /// <a href="https://cloud.tencent.com/document/api/607/35375#DescribeScanResult" target="_blank">DescribeScanResult</a>）</font>：</li>
        /// <pre><code>{
        /// 	"Code": 0,
        /// 	"DataId": "1400000000_test_data_id",
        /// 	"ScanFinishTime": 1566720906,
        /// 	"HitFlag": true,
        /// 	"Live": false,
        /// 	"Msg": "",
        /// 	"ScanPiece": [{
        /// 		"DumpUrl": "",
        /// 		"HitFlag": true,
        /// 		"MainType": "abuse",
        /// 		"RoomId": "123",
        /// 		"OpenId": "xxx",
        /// 		"Info":"",
        /// 		"Offset": 0,
        /// 		"Duration": 3400,
        /// 		"PieceStartTime":1574684231,
        /// 		"ScanDetail": [{
        /// 			"EndTime": 1110,
        /// 			"KeyWord": "xxx",
        /// 			"Label": "abuse",
        /// 			"Rate": "90.00",
        /// 			"StartTime": 1110
        /// 		}, {
        /// 			"EndTime": 1380,
        /// 			"KeyWord": "xxx",
        /// 			"Label": "abuse",
        /// 			"Rate": "90.00",
        /// 			"StartTime": 930
        /// 		}, {
        /// 			"EndTime": 1560,
        /// 			"KeyWord": "xxx",
        /// 			"Label": "abuse",
        /// 			"Rate": "90.00",
        /// 			"StartTime": 930
        /// 		}, {
        /// 			"EndTime": 2820,
        /// 			"KeyWord": "xxx",
        /// 			"Label": "abuse",
        /// 			"Rate": "90.00",
        /// 			"StartTime": 2490
        /// 		}]
        /// 	}],
        /// 	"ScanStartTime": 1566720905,
        /// 	"Scenes": [
        /// 		"default"
        /// 	],
        /// 	"Status": "Success",
        /// 	"TaskId": "xxx",
        /// 	"Url": "https://xxx/xxx.m4a"
        /// }
        /// </code></pre>
        /// </summary>
        /// <param name="req"><see cref="ScanVoiceRequest"/></param>
        /// <returns><see cref="ScanVoiceResponse"/></returns>
        public async Task<ScanVoiceResponse> ScanVoice(ScanVoiceRequest req)
        {
             JsonResponseModel<ScanVoiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ScanVoice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScanVoiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ScanVoice接口的同步版本，本接口(ScanVoice)用于提交语音检测任务，检测任务列表最多支持100个。使用前请您登录[控制台 - 服务配置](https://console.cloud.tencent.com/gamegme/conf)开启语音分析服务。
        /// </br></br>
        /// 
        /// <h4><b>功能试用说明：</b></h4>
        /// <li>打开前往<a href="https://console.cloud.tencent.com/gamegme/tryout">控制台 - 产品试用</a>免费试用语音分析服务。</li>
        /// </br>
        /// 
        /// <h4><b>接口功能说明：</b></h4>
        /// <li>支持对语音流或语音文件进行检测，判断其中是否包含违规内容。</li>
        /// <li>支持设置回调地址 Callback 获取检测结果，同时支持通过接口(查询语音检测结果)主动轮询获取检测结果。</li>
        /// <li>支持场景输入，包括：谩骂、色情、涉政等场景</li>
        /// <li>支持批量提交检测任务。检测任务列表最多支持100个。</li>
        /// </br>
        /// <h4><b>音频文件限制说明：</b></h4>
        /// <li>音频文件大小限制：100 M</li>
        /// <li>音频文件时长限制：30分钟</li>
        /// <li>音频文件格式支持的类型：.wav、.m4a、.amr、.mp3、.aac、.wma、.ogg</li>
        /// </br>
        /// <h4><b>语音流限制说明：</b></h4>
        /// <li>语音流格式支持的类型：.m3u8、.flv</li>
        /// <li>语音流支持的传输协议：RTMP、HTTP、HTTPS</li>
        /// <li>语音流时长限制：4小时</li>
        /// <li>支持音视频流分离并对音频流进行分析</li>
        /// </br>
        /// <h4 id="Label_Value"><b>Scenes 与 Label 参数说明：</b></h4>
        /// <p>提交语音检测任务时，需要指定 Scenes 场景参数，<font color="red">目前要求您设置 Scenes 参数值为：["default"]</font>；而在检测结果中，则包含请求时指定的场景，以及对应类型的检测结果。</p>
        /// <table>
        /// <thread>
        /// <tr>
        /// <th>场景</th>
        /// <th>描述</th>
        /// <th>Label</th>
        /// </tr>
        /// </thread>
        /// <tbody>
        /// <tr>
        /// <td>语音检测</td>
        /// <td>语音检测的检测类型</td>
        /// <td>
        /// <p>normal:正常文本</p>
        /// <p>porn:色情</p>
        /// <p>politics:涉政</p>
        /// <p>abuse:谩骂</p>
        /// <p>ad :广告</p>
        /// <p>terrorism:暴恐</p>
        /// <p>contraband :违禁</p>
        /// <p>customized:自定义词库。目前白名单开放，如有需要请<a href="https://cloud.tencent.com/apply/p/8809fjcik56">联系我们</a>。</p>
        /// </td>
        /// </tr>
        /// </tbody>
        /// </table>
        /// </br>
        /// <h4 id="Callback_Declare"><b>回调相关说明：</b></h4>
        /// <li>如果在请求参数中指定了回调地址参数 Callback，即一个 HTTP(S) 协议接口的 URL，则需要支持 POST 方法，传输数据编码采用 UTF-8。</li>
        /// <li>在推送回调数据后，接收到的 HTTP 状态码为 200 时，表示推送成功。</li>
        /// <li>HTTP 头参数说明：</li>
        /// <table>
        /// <thread>
        /// <tr>
        /// <th>名称</th>
        /// <th>类型</th>
        /// <th>是否必需</th>
        /// <th>描述</th>
        /// </tr>
        /// </thread>
        /// <tbody>
        /// <tr>
        /// <td>Signatue</td>
        /// <td>string</td>
        /// <td>是</td>
        /// <td>签名，具体见<a href="#Callback_Signatue">签名生成说明</a></td>
        /// </tr>
        /// </tbody>
        /// </table>
        /// <ul  id="Callback_Signatue">
        /// 	<li>签名生成说明：</li>
        /// 	<ul>
        /// 		<li>使用 HMAC-SH1 算法, 最终结果做 BASE64 编码;</li>
        /// 		<li>签名原文串为 POST+body 的整个json内容(长度以 Content-Length 为准);</li>
        /// 		<li>签名key为应用的 SecretKey，可以通过控制台查看。</li>
        /// 	</ul>
        /// </ul>
        /// 
        /// <li>回调示例如下<font color="red">（详细字段说明见结构：
        /// <a href="https://cloud.tencent.com/document/api/607/35375#DescribeScanResult" target="_blank">DescribeScanResult</a>）</font>：</li>
        /// <pre><code>{
        /// 	"Code": 0,
        /// 	"DataId": "1400000000_test_data_id",
        /// 	"ScanFinishTime": 1566720906,
        /// 	"HitFlag": true,
        /// 	"Live": false,
        /// 	"Msg": "",
        /// 	"ScanPiece": [{
        /// 		"DumpUrl": "",
        /// 		"HitFlag": true,
        /// 		"MainType": "abuse",
        /// 		"RoomId": "123",
        /// 		"OpenId": "xxx",
        /// 		"Info":"",
        /// 		"Offset": 0,
        /// 		"Duration": 3400,
        /// 		"PieceStartTime":1574684231,
        /// 		"ScanDetail": [{
        /// 			"EndTime": 1110,
        /// 			"KeyWord": "xxx",
        /// 			"Label": "abuse",
        /// 			"Rate": "90.00",
        /// 			"StartTime": 1110
        /// 		}, {
        /// 			"EndTime": 1380,
        /// 			"KeyWord": "xxx",
        /// 			"Label": "abuse",
        /// 			"Rate": "90.00",
        /// 			"StartTime": 930
        /// 		}, {
        /// 			"EndTime": 1560,
        /// 			"KeyWord": "xxx",
        /// 			"Label": "abuse",
        /// 			"Rate": "90.00",
        /// 			"StartTime": 930
        /// 		}, {
        /// 			"EndTime": 2820,
        /// 			"KeyWord": "xxx",
        /// 			"Label": "abuse",
        /// 			"Rate": "90.00",
        /// 			"StartTime": 2490
        /// 		}]
        /// 	}],
        /// 	"ScanStartTime": 1566720905,
        /// 	"Scenes": [
        /// 		"default"
        /// 	],
        /// 	"Status": "Success",
        /// 	"TaskId": "xxx",
        /// 	"Url": "https://xxx/xxx.m4a"
        /// }
        /// </code></pre>
        /// </summary>
        /// <param name="req">参考<see cref="ScanVoiceRequest"/></param>
        /// <returns>参考<see cref="ScanVoiceResponse"/>实例</returns>
        public ScanVoiceResponse ScanVoiceSync(ScanVoiceRequest req)
        {
             JsonResponseModel<ScanVoiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ScanVoice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScanVoiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于识别涉黄、涉政等违规音频，成功会回调配置在应用的回调地址。回调示例如下：
        /// {"BizId":0,"FileId":"test_file_id","FileName":"test_file_name","FileUrl":"test_file_url","OpenId":"test_open_id","TimeStamp":"0000-00-00 00:00:00","Data":[{"Type":1,"Word":"xx"}]}
        /// Type表示过滤类型，1：政治，2：色情，3：谩骂
        /// </summary>
        /// <param name="req"><see cref="VoiceFilterRequest"/></param>
        /// <returns><see cref="VoiceFilterResponse"/></returns>
        public async Task<VoiceFilterResponse> VoiceFilter(VoiceFilterRequest req)
        {
             JsonResponseModel<VoiceFilterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VoiceFilter");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VoiceFilterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// VoiceFilter接口的同步版本，本接口用于识别涉黄、涉政等违规音频，成功会回调配置在应用的回调地址。回调示例如下：
        /// {"BizId":0,"FileId":"test_file_id","FileName":"test_file_name","FileUrl":"test_file_url","OpenId":"test_open_id","TimeStamp":"0000-00-00 00:00:00","Data":[{"Type":1,"Word":"xx"}]}
        /// Type表示过滤类型，1：政治，2：色情，3：谩骂
        /// </summary>
        /// <param name="req">参考<see cref="VoiceFilterRequest"/></param>
        /// <returns>参考<see cref="VoiceFilterResponse"/>实例</returns>
        public VoiceFilterResponse VoiceFilterSync(VoiceFilterRequest req)
        {
             JsonResponseModel<VoiceFilterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "VoiceFilter");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VoiceFilterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
